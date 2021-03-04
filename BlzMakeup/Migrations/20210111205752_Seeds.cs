using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BlzMakeup.Migrations
{
	public partial class Seeds : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome) VALUES('Face')");
			migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome) VALUES('Olhos')");
			migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome) VALUES('Skincare')");

			migrationBuilder.Sql("INSERT INTO Produtos( CategoriaId, DescricaoCurta, DescricaoDetalhada, Estoque, ImagemThumbnailUrl, ImagemUrl, Destaque, Nome, Preco)VALUES( (SELECT Id FROM Categorias WHERE CategoriaNome='Skincare'), 'Lenço Demaquilante Max Love', 'Lenço demaquilante sem álcool com 7 funções: Demaquila, limpa, purifica, hidrata, suaviza, tonifica e refresca a pele do rosto. Remove impurezas e maquiagem à prova d’água.', 1, 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2Fc4c2f934-e747-4afa-a6bc-17a2257a555f.jpg?alt=media', 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2Fc4c2f934-e747-4afa-a6bc-17a2257a555f.jpg?alt=media', 0, 'Lenço Demaquilante Max Love', 10.90)");

			migrationBuilder.Sql("INSERT INTO Produtos( CategoriaId, DescricaoCurta, DescricaoDetalhada, Estoque, ImagemThumbnailUrl, ImagemUrl, Destaque, Nome, Preco)VALUES( (SELECT Id FROM Categorias WHERE CategoriaNome='Skincare'), 'Gel Esfoliante com Pedras Vulcânicas', 'O Gel Esfoliante Facial, da Dermachem, garante limpeza profunda com efeito detox para você conquistar uma pele renovada e com viço natural.  Enquanto limpa profundamente, o gel também esfolia, proporcionando agradável sensação de pele renovada, pois remove as células mortas para uma derme mais macia, sedosa e saudável.', 1, 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2F728fae8c-2a73-4ea8-bdb1-85d7faa9a391.jpg?alt=media', 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2F728fae8c-2a73-4ea8-bdb1-85d7faa9a391.jpg?alt=media', 1, 'Gel Esfoliante com Pedras Vulcânicas', 15.90)");

			migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId, DescricaoCurta, DescricaoDetalhada, Estoque, ImagemThumbnailUrl, ImagemUrl, Destaque, Nome, Preco)VALUES( (SELECT Id FROM Categorias WHERE CategoriaNome='Face'), 'Corretivo Duo Sculpt Feels Chantilly 10 E Avelã 70 – Ruby Rose', 'Corretivo Duo Sculpt Feels Chantilly 10 e Avelã 70 – Ruby Rose O Corretivo Duo Sculpt Feels possui duas tonalidades de corretivo com textura sequinha de alta cobertura para definir traços e iluminar o rosto e corrigir.', 1, 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2F75dea00e-7034-4a7c-a20a-3ba4be754168.jpg?alt=media', 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2F75dea00e-7034-4a7c-a20a-3ba4be754168.jpg?alt=media', 0, 'Corretivo Duo Sculpt Feels Chantilly 10 E Avelã 70 – Ruby Rose', 18.90) ");

			migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId, DescricaoCurta, DescricaoDetalhada, Estoque, ImagemThumbnailUrl, ImagemUrl, Destaque, Nome, Preco)VALUES( (SELECT Id FROM Categorias WHERE CategoriaNome='Face'), 'Iluminador Glow Baby Dalla - Cor 1 Rose', 'O Iluminador Glow Baby Glow Pocket da Dalla Makeup tem textura cremosa, mas não é oleosa, possui muita pigmentação e um glow (brilho) maravilhoso. Espalha fácil, tem excelente fixação, pode ser usado também como sombra, além nas regiões de iluminação: canto dos olhos, e regiões da face e lábios. Além disso tudo, vem na versão Pocket, perfeito para te acompanhar na bolsa ou nécessaire. ', 1, 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2Ffbb5a32f-1ad8-4e34-afbe-8ae4d95cb9a5.jpg?alt=media', 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2Ffbb5a32f-1ad8-4e34-afbe-8ae4d95cb9a5.jpg?alt=media', 1, 'Iluminador Glow Baby Dalla - Cor 1 Rose', 12.90)");

			migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId, DescricaoCurta, DescricaoDetalhada, Estoque, ImagemThumbnailUrl, ImagemUrl, Destaque, Nome, Preco)VALUES( (SELECT Id FROM Categorias WHERE CategoriaNome='Olhos'), 'Cílios Pop Culture Dapop - Definição', 'MÁSCARA DE CÍLIOS POP CULTURE - DAPOP - Para quem ama um volumão, alongamento e definição, chegou a máscara de cílios DaPop, contendo secagem rápida, boa pigmentação e o melhor de tudo, sua formula é resistente a água. Pop Culture Amarelo: Cílios definido dando destaque e glamour pra qualquer maquiagem, com suas cerdas pequena e fina você não terá problemas pra alcançar até os menores fios.', 1, 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2F66ee4232-ae88-4747-a6b5-c24c4ee877c1.jpg?alt=media', 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2F66ee4232-ae88-4747-a6b5-c24c4ee877c1.jpg?alt=media', 1, 'Cílios Pop Culture Dapop - Definição', 16.00)");

			migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId, DescricaoCurta, DescricaoDetalhada, Estoque, ImagemThumbnailUrl, ImagemUrl, Destaque, Nome, Preco)VALUES( (SELECT Id FROM Categorias WHERE CategoriaNome='Olhos'), 'Delineador Líquido Intense Black - Pink 21', 'Delineador líquido Intense black, da pink 21, com aplicador de ponta fininha, garantindo aquele olhar marcante super fino com alta pigmentação e fixação. ah! ele também é à prova d’água, então, você pode aproveitar muito sem preocupações.', 1, 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2F2571f0ef-cee4-4c78-b1cc-01eabc7c09c9.jpg?alt=media', 'https://firebasestorage.googleapis.com/v0/b/kyte-7c484.appspot.com/o/WlRn67LJT2OinFLeo0ekajLRjcn2%2F2571f0ef-cee4-4c78-b1cc-01eabc7c09c9.jpg?alt=media', 0, 'Delineador Líquido Intense Black - Pink 21', 13.90)");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql("DELETE FROM Categorias");
			migrationBuilder.Sql("DELETE FROM Produtos");
		}
	}
}
