using ecomm1_2A.classes;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecomm1_2A.Helpers
{
    public class MovEstoque
    {
        public static void Gerar(Produto prod, int qtd)
        {
            PdfDocument pdfDocument = new PdfDocument(
                new PdfWriter(new FileStream (
                    @"relatorios\"+prod.Nome+".pdf", FileMode.Create, FileAccess.Write)));
            Document document = new Document(pdfDocument);

            Table table = new Table(6, true);

            table.StartNewRow();
            table.AddCell("GKHaven");
            table.AddCell(new Cell(1, 5).Add(new Paragraph("Av. Nações Unidas, 50-58")));

            table.StartNewRow();
            table.AddCell(new Cell(1, 6));

            table.StartNewRow();
            table.AddCell(new Cell(1, 6).Add(new Paragraph("CONTROLE DE ESTOQUE 2024 - " + prod.Nome)))
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
            table.AddCell(prod.Valor_unitario.ToString());

            //FAZER O RESTANTE DO RELATÓRIO:
            //  => Foreach para mostrar as compras onde teve saída desse prod
            //  => Linha de totalização mostrando a saída final sl = e - s  
            // Sl0 = E0 - S0   saldo inicial = entrada inicial (param) - saida inicial  97 = e - 1
            // Sln = Sln-1 + En - Sn -> sld = sld + 0 - compraproduto.Qtd;
            //int sld = qtd;

            int sld = qtd;
            int entrada;
            double custo;
            double custoTotal = 0;
            
            foreach (CompraProduto compra in prod.Compras)
            {
                if (compra.Compra.Status == "FINALIZADO")
                {
                    entrada = sld;
                    sld -= compra.Quantidade;
                    custo = compra.Valor_unitario * (entrada - sld); // n vai ser isso n ksks mas isso e pra dps e o vitinho falou q pode deixar assim :D
                    custoTotal += custo;

                    table.StartNewRow();
                    table.AddCell(compra.Compra.Data.ToString()); // data
                    table.AddCell(compra.Compra.Comprador.Nome.ToString()); // descricao
                    table.AddCell(entrada.ToString()); // entrada
                    table.AddCell(compra.Quantidade.ToString()); // saida
                    table.AddCell(sld.ToString()); // saldo 
                    table.AddCell(custo.ToString()); // custo
                }
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