using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produto(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('Coca-cola zero', 'Refrigerante de cola 250ml', 1.98, 'cocacola.jpg', 30, now(),1  )");

            mb.Sql("Insert into Produto(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('Lanche de Atum', 'Lanche de Atum com maionese', 5.50, 'atum.jpg', 15, now(),2  )");

            mb.Sql("Insert into Produto(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('Cocada', 'Cocada 100g', 3.0, 'cocada.jpg', 5, now(),3  )");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produto");
        }
    }
}
