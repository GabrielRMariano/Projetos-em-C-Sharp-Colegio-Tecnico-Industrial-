﻿using proj_final.Classes;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proj_final.Helpers
{
    public class MovEstoque
    {
        public static void Gerar(Jogo j, int qtd)
        {
            PdfDocument pdfDocument = new PdfDocument(
                new PdfWriter(new FileStream(
                    @"relatorios\" + j.Titulo + ".pdf", FileMode.Create, FileAccess.Write)));
            Document document = new Document(pdfDocument);

            Table table = new Table(6, true);

            table.StartNewRow();
            table.AddCell("JPGames");
            table.AddCell(new Cell(1, 5).Add(new Paragraph("Av. Nações Unidas, 58-50")));

            table.StartNewRow();
            table.AddCell(new Cell(1, 6));

            table.StartNewRow();
            table.AddCell(new Cell(1, 6).Add(new Paragraph("CONTROLE DE ESTOQUE - " + j.Titulo)))
                .SetTextAlignment(TextAlignment.CENTER);

            table.StartNewRow();
            table.AddCell(new Cell(1, 6));

            table.StartNewRow();
            table.AddCell(new Cell(1, 2).Add(new Paragraph("Dados")));
            table.AddCell(new Cell(1, 3).Add(new Paragraph("Movimentação")));
            table.AddCell("");

            table.StartNewRow();
            table.AddCell("DATA");
            table.AddCell("DESCRIÇÃO");
            table.AddCell("ENTRADA");
            table.AddCell("SAÍDA");
            table.AddCell("SALDO");
            table.AddCell("CUSTO");

            //INÍCIO DO PREENCHIMENTO DA TABELA - linha de entrada no estoque
            table.StartNewRow();
            table.AddCell("--");
            table.AddCell("Estoque inicial");
            table.AddCell(qtd.ToString());
            table.AddCell("0");
            table.AddCell(qtd.ToString());
            table.AddCell(j.Preco.ToString());

            int sld = qtd;
            int entrada;
            double custo;
            double custoTotal = 0;

            foreach (ComprasJogo compra in j.Cj)
            {
                entrada = sld;
                sld += compra.Quantidade;
                custo = compra.ValorPago * compra.Quantidade;
                custoTotal += custo;

                table.StartNewRow();
                table.AddCell(compra.Compra.Data_compra.ToString()); // data
                table.AddCell("Compra"); // descricao
                table.AddCell(compra.Quantidade.ToString()); // entrada
                table.AddCell("0"); // saida
                table.AddCell(sld.ToString()); // saldo 
                table.AddCell(custo.ToString()); // custo

            }

            table.StartNewRow();
            table.AddCell(new Cell(1, 4).Add(new Paragraph("TOTAL")));
            table.AddCell(sld.ToString());
            table.AddCell(custoTotal.ToString());

            document.Add(table);
            document.Close();

            MessageBox.Show("Gerado com sucesso");
        }
    }
}
