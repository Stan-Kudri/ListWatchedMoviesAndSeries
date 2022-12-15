using Core.Model.Item;
using Core.Repository.DbContex;
using ListWatchedMoviesAndSeries.EditorForm;
using ListWatchedMoviesAndSeries.Model;
using ListWatchedMoviesAndSeries.Models;
using ListWatchedMoviesAndSeries.Models.Item;
using ListWatchedMoviesAndSeries.Repository;
using Microsoft.EntityFrameworkCore;

namespace ListWatchedMoviesAndSeries
{
    /// <summary>
    /// This is the main form class.
    /// </summary>
    public partial class BoxCinemaForm : Form
    {
        private const int IndexColumnName = 0;
        private const int IndexColumnSequel = 1;
        private const int IndexColumnStatus = 2;
        private const int IndexColumnDate = 3;
        private const int IndexColumnGrade = 4;
        private const int IndexColumnId = 5;
        private const int IndexColumnType = 6;

        private readonly WatchCinemaDbContext _db;

        private readonly WatchItemRepository _repository;

        public BoxCinemaForm()
        {
            InitializeComponent();

            var builder = new DbContextOptionsBuilder().UseSqlite("Data Source=app.db");
            _db = new WatchCinemaDbContext(builder.Options);
            _repository = new WatchItemRepository(_db);

            Load += BoxCinemaForm_Load;
            LoadData();
        }

        private FilterModel Filter { get; set; } = new FilterModel();

        public void SetNameGrid(CinemaModel cinema)
        {
            if (cinema?.Type != null)
            {
                AddCinemaGridRow(cinema);
                _repository.Add(cinema.ToWatchItem());
            }
        }

        public void EditItemGrid(CinemaModel cinema, int numberRowGridCinema)
        {
            if (cinema?.Type != null)
            {
                ReplacementEditItem(cinema, numberRowGridCinema);
                _repository.Update(cinema.ToWatchItem());
            }
        }

        private void BoxCinemaForm_Load(object? sender, EventArgs e)
        {
            _db.Database.EnsureCreated();
            cmbFilterType.DataSource = Filter.TypeFilter;
            cmbFilterWatch.DataSource = Filter.WatchFilter;
            filterModelBindingSource.DataSource = Filter;
        }

        private void BtnFormMovie_Click(object sender, EventArgs e)
        {
            using (var form = new AddCinemaForm(this, TypeCinema.Movie))
            {
                form.ShowDialog();
            }
        }

        private void BtnFormSeries_Click(object sender, EventArgs e)
        {
            using (var form = new AddCinemaForm(this, TypeCinema.Series))
            {
                form.ShowDialog();
            }
        }

        private void BtnFormAnime_Click(object sender, EventArgs e)
        {
            using (var form = new AddCinemaForm(this, TypeCinema.Anime))
            {
                form.ShowDialog();
            }
        }

        private void BtnFormCartoon_Click(object sender, EventArgs e)
        {
            using (var form = new AddCinemaForm(this, TypeCinema.Cartoon))
            {
                form.ShowDialog();
            }
        }

        private void BtnUseFilter_Click(object sender, EventArgs e)
        {
            if (Filter.HasFilter() && !IsChangesFilter())
            {
                GridClear();
                var filter = Filter.GetFilter();
                var listByFilter = _repository.GetItemByFilter(filter);
                AddCinemaGrid(listByFilter);
            }
            else
            {
                GridClear();
                AddCinemaGrid(_repository.GetAll());
            }
        }

        private void BtnCancleFilter_Click(object sender, EventArgs e)
        {
            if (Filter.HasFilter())
            {
                GridClear();
                LoadData();
            }
        }

        private void BtnEditRow_Click(object sender, EventArgs e)
        {
            if (IsEditRowGrid(out int indexRowMove, out CinemaModel? item) && item != null)
            {
                ShowEditCinema(item, indexRowMove);
            }
        }

        private void BtnDeliteMovie_Click(object sender, EventArgs e)
        {
            if (RemoveRowGrid(out string idItem))
            {
                if (!Guid.TryParse(idItem, out var id))
                {
                    return;
                }

                _repository.Remove(id);
            }
        }

        private void BtnReplaceFile_Click(object sender, EventArgs e)
        {
            var openReplaceDataFromFile = new OpenFileDialog { Filter = "Data Base (*.db)|*.db" };
            if (openReplaceDataFromFile.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string fileName = openReplaceDataFromFile.FileName;

            var builder = new DbContextOptionsBuilder().UseSqlite($"Data Source={fileName}");
            var repository = new WatchItemRepository(new WatchCinemaDbContext(builder.Options));

            _repository.RemoveRange();
            _repository.Add(repository.GetAll());

            GridClear();
            LoadData(repository);
        }

        /// <summary>
        /// Deleting a row of table data.
        /// Out ID in delete from another table.
        /// </summary>
        /// <param name="id">Object ID to delete.</param>
        /// <returns>Is item remove.</returns>
        private bool RemoveRowGrid(out string id)
        {
            if (dgvCinema.SelectedRows.Count == 0)
            {
                id = string.Empty;
                MessageBoxProvider.ShowWarning("Highlight the desired line");
                return false;
            }

            id = SelectedRowCinemaId();
            RemoveItemRowGrid(id);

            return true;
        }

        /// <summary>
        /// Get ID on the selected line table.
        /// </summary>
        /// <returns> ID. </returns>
        private string SelectedRowCinemaId()
        {
            var rowIndex = dgvCinema.CurrentCell.RowIndex;
            var id = dgvCinema.Rows[rowIndex].Cells[IndexColumnId].Value;
            return id.ToString() ?? string.Empty;
        }

        /// <summary>
        /// Delete line table by Id.
        /// </summary>
        /// <param name="id">Object ID to delete.</param>
        private void RemoveItemRowGrid(string? id)
        {
            if (dgvCinema.RowCount == 0)
            {
                MessageBoxProvider.ShowError("The element is missing from the table.");
            }

            foreach (DataGridViewRow row in dgvCinema.Rows)
            {
                if (row.Cells[IndexColumnId].Value.ToString() == id)
                {
                    dgvCinema.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }

        /// <summary>
        /// Add element in table.
        /// </summary>
        /// <param name="cinema">Add element. </param>
        private void AddCinemaGridRow(CinemaModel cinema)
        {
            var intSequel = decimal.ToInt64(cinema.NumberSequel ?? 0);
            var formatDate = cinema.Detail.GetWatchData();
            dgvCinema.Rows.Add(cinema.Name, intSequel.ToString(), cinema.Status.Name, formatDate, cinema.Detail?.Grade, cinema.Id.ToString(), cinema.Type);
        }

        /// <summary>
        /// Filling the table with data.
        /// </summary>
        /// <param name="itemGrid">List of elements.</param>
        private void AddCinemaGrid(List<WatchItem> itemGrid)
        {
            foreach (var item in itemGrid)
            {
                var intSequel = decimal.ToInt64(item.NumberSequel ?? 0);
                var formatDate = item.Detail?.GetWatchData();
                dgvCinema.Rows.Add(item.Name, intSequel.ToString(), item.Status.Name, formatDate, item.Detail?.Grade, item.Id.ToString(), item.Type);
            }
        }

        /// <summary>
        /// Edit the selected item.
        /// </summary>
        /// <param name="rowIndex">Number row element.</param>
        /// <param name="cinemaItem">Element to сhange.</param>
        /// <returns>
        /// True:Row selected.
        /// False:Row not selected.
        /// </returns>
        private bool IsEditRowGrid(out int rowIndex, out CinemaModel? cinemaItem)
        {
            if (dgvCinema.SelectedRows.Count == 0)
            {
                rowIndex = -1;
                cinemaItem = null;
                MessageBoxProvider.ShowWarning("Highlight the desired line");
                return false;
            }

            rowIndex = dgvCinema.CurrentCell.RowIndex;
            cinemaItem = GetItem(rowIndex);
            return true;
        }

        /// <summary>
        /// Change the selected element in the EditorItemCinemaForm.
        /// </summary>
        /// <param name="item">Element to сhange.</param>
        /// <param name="indexRow">Number row element.</param>
        private void ShowEditCinema(CinemaModel item, int indexRow)
        {
            var id = item.Id.ToString() ?? string.Empty;
            using (var form = new EditorItemCinemaForm(this, item, indexRow))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Get item by ID from the table.
        /// </summary>
        /// <param name="indexRow">Number row element.</param>
        /// <returns>
        /// The filling of all fields of the element depends on the data in the table.
        /// Type: CinemaModel.
        /// </returns>
        private CinemaModel GetItem(int indexRow)
        {
            var rowItems = dgvCinema.Rows[indexRow];
            var title = CellElement(rowItems, IndexColumnName) ?? throw new ArgumentException("Name cannot be null.");
            if (!decimal.TryParse(CellElement(rowItems, IndexColumnSequel) ?? throw new ArgumentException("Sequel cannot be null."), out var sequel))
            {
                throw new InvalidOperationException("Invalid cast.");
            }

            if (!Guid.TryParse(CellElement(rowItems, IndexColumnId), out var id))
            {
                throw new InvalidOperationException("Invalid cast.");
            }

            var type = TypeCinema.FromName(CellElement(rowItems, IndexColumnType));
            var strDateWatch = CellElement(rowItems, IndexColumnDate);
            var status = StatusCinema.FromName(CellElement(rowItems, IndexColumnStatus));

            if (strDateWatch != string.Empty && strDateWatch != null)
            {
                var dateWatch = DateTime.Parse(strDateWatch);
                if (!decimal.TryParse(CellElement(rowItems, IndexColumnGrade) ?? throw new ArgumentException("Grade cannot be null."), out var grade))
                {
                    throw new InvalidOperationException("Invalid cast.");
                }

                var cinemaItem = new CinemaModel(
                                                   title,
                                                   sequel,
                                                   dateWatch,
                                                   grade,
                                                   status,
                                                   type,
                                                   id);
                return cinemaItem;
            }
            else
            {
                var cinemaItem = new CinemaModel(
                                                  title,
                                                  sequel,
                                                  status,
                                                  type,
                                                  id);
                return cinemaItem;
            }
        }

        private string? CellElement(DataGridViewRow rowItem, int indexColumn) => rowItem.Cells[indexColumn].Value.ToString();

        /// <summary>
        /// Changing a table element.
        /// </summary>
        /// <param name="cinemaItem">Element to change.</param>
        /// <param name="rowIndex">Number row element.</param>
        private void ReplacementEditItem(CinemaModel cinemaItem, int rowIndex)
        {
            dgvCinema.Rows[rowIndex].Cells[IndexColumnName].Value = cinemaItem.Name;
            dgvCinema.Rows[rowIndex].Cells[IndexColumnSequel].Value = cinemaItem.NumberSequel;
            dgvCinema.Rows[rowIndex].Cells[IndexColumnId].Value = cinemaItem.Id;
            dgvCinema.Rows[rowIndex].Cells[IndexColumnType].Value = cinemaItem.Type;

            if (cinemaItem.Detail.HasWatchDate())
            {
                dgvCinema.Rows[rowIndex].Cells[IndexColumnStatus].Value = StatusCinema.Watch;
                dgvCinema.Rows[rowIndex].Cells[IndexColumnDate].Value = cinemaItem.Detail.GetWatchData();
                dgvCinema.Rows[rowIndex].Cells[IndexColumnGrade].Value = cinemaItem.Detail.Grade;
            }
            else
            {
                dgvCinema.Rows[rowIndex].Cells[IndexColumnStatus].Value = StatusCinema.NotWatch;
                dgvCinema.Rows[rowIndex].Cells[IndexColumnDate].Value = string.Empty;
                dgvCinema.Rows[rowIndex].Cells[IndexColumnGrade].Value = string.Empty;
            }
        }

        /// <summary>
        /// Filling in tabular data from a file.
        /// </summary>
        /// <param name="grid">Table to fill.</param>
        private void LoadData()
        {
            try
            {
                var itemGrid = _repository.GetAll();
                if (itemGrid == null || itemGrid.Count <= 0)
                {
                    return;
                }

                AddCinemaGrid(itemGrid);
            }
            catch (Exception error)
            {
                MessageBoxProvider.ShowError(error.Message);
            }
        }

        private void LoadData(WatchItemRepository repository)
        {
            try
            {
                var itemGrid = repository.GetAll();
                if (itemGrid == null || itemGrid.Count <= 0)
                {
                    return;
                }

                AddCinemaGrid(itemGrid);
            }
            catch (Exception error)
            {
                MessageBoxProvider.ShowError(error.Message);
            }
        }

        private void GridClear() => dgvCinema.Rows.Clear();

        private bool IsChangesFilter() => Filter.Equals(_repository.PastFilter);
    }
}
