using Microsoft.EntityFrameworkCore;

namespace Projekt1000.DbContext;

public class DbContext
{
    private readonly ViewModel.ViewModel _viewmodel;
    private readonly MainWindow _mainWindow;
    private readonly ProductContext _context;
    public DbContext(ViewModel.ViewModel viewModel, MainWindow mainWindow)
    {
        _viewmodel = viewModel;
        _mainWindow = mainWindow;

        _context = new ProductContext();
        _context.Database.Migrate();

        if (_context.Categories is null || _context.Products is null) { return; }

        _context.Categories.Load();
        _context.Products.Load();

        viewModel.Categories = _context.Categories.Local.ToObservableCollection();
        viewModel.Products = _context.Products.Local.ToObservableCollection();

        UebersichtAktualisieren();
    }
    public void AenderungenSpeichern()
    {
        if (_context.Categories is null) { return; }

        _ = _context.SaveChanges();

        UebersichtAktualisieren();

        _mainWindow.DataGridCategories.Items.Refresh();
        _mainWindow.DataGridProducts.Items.Refresh();
        _mainWindow.DataGridUebersicht.Items.Refresh();
    }
    private void UebersichtAktualisieren()
    {
        _mainWindow.ViewModel.Uebersicht = [];

        foreach (var category in _viewmodel.Categories)
        {
            if (category.Products.Count == 0) { continue; }

            var categorieUeberschrift = false;

            foreach (var product in category.Products.Where(product => category.CategoryId == product.CategoryId))
            {
                if (!categorieUeberschrift)
                {
                    categorieUeberschrift = true;

                    _mainWindow.ViewModel.Uebersicht.Add(new Uebersicht
                    {
                        CategoryId = category.CategoryId.ToString(),
                        CategoryName = category.Name,
                        ProductId = product.ProductId.ToString(),
                        ProductName = product.Name
                    });
                }
                else
                {
                    _mainWindow.ViewModel.Uebersicht.Add(new Uebersicht
                    {
                        CategoryId = string.Empty,
                        CategoryName = string.Empty,
                        ProductId = product.ProductId.ToString(),
                        ProductName = product.Name
                    });
                }
            }
        }
    }

    public void DbClose() => _context.Dispose();
}
