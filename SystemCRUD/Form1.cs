namespace SystemCRUD

{

    using System.Data;
    using Dapper;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.Configuration;
    using SystemCRUD.Models;

    public partial class MainForm : Form
    {
        private readonly string _connectionString;
        private List<Product> _products = new();

        public MainForm(IConfiguration config)
        {
            InitializeComponent();
            _connectionString = config.GetConnectionString("Default");
        }

        private void RefreshData(IDbConnection con)
        {
            _products = con.Query<Product>(
                "select * from Product"
                ) .AsList();
            ProductList.DataSource = _products;
        }
        private void CreateButton_Click(object sender, EventArgs e)  
        {

            var product = new Product
            {
                Code = CodeTextBox.Text,
                Name = NameTextBox.Text,
                Description = DescriptionTextBox.Text,
                Date = DateTime.Now
            };

            using var con = new SqlConnection(_connectionString);
            con.Execute(
             @"insert into Product 
            values (@Code, @Name, @Description, @Date)",
            product
            );
            RefreshData(con);

        }



        private void UpDateButton_Click(object sender, EventArgs e)
        {
            if (ProductList.CurrentRow is null)
                return;

            var product = new Product
            {
                Id = _products[ProductList.CurrentRow.Index].Id,
                Code = CodeTextBox.Text,
                Name = NameTextBox.Text,
                Description = DescriptionTextBox.Text,
                Date = DateTime.Now
            };

            using var con = new SqlConnection(_connectionString);
            con.Execute(
                @"update Product set
                    code = @Code,
                    name = @Name,
                    description = @Description,
                    date = @Date
                    where id = @Id",
                    product
                );

            RefreshData(con);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductList.CurrentRow is null)
                return;

            using var con = new SqlConnection(_connectionString);
            con.Execute(
                "delete Product where id = @id",
                new { id = _products[ProductList.CurrentRow.Index].Id }
                );
            RefreshData(con);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using var con = new SqlConnection(_connectionString);
            RefreshData(con);
        }
    }
}