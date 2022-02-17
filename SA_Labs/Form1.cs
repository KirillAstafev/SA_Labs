using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_Labs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            vertexComboBox.SelectedItem = "1";

            int vertexCount = int.Parse(vertexComboBox.SelectedItem.ToString());
            InitializeMatrix(matrixDataGrid, vertexCount, vertexCount);
        }

        private void InitializeMatrix(DataGridView matrix, int rowCount, int columnCount)
        {
            matrix.RowCount = rowCount;
            matrix.ColumnCount = columnCount;

            for(int i = 0; i < matrix.RowCount; i++)
            {
                DataGridViewRow row = matrix.Rows[i];
                row.HeaderCell.Value = string.Format((i + 1).ToString(), "0");

                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = 0;
            }

            for (int i = 0; i < matrix.ColumnCount; i++)
            {
                matrix.Columns[i].HeaderText = Convert.ToString(i + 1);
            }
        }

        private int getUndirectedEdgeCount()
        {
            int edgeCount = 0;

            try
            {
                for (int i = 0; i < matrixDataGrid.RowCount - 1; i++)
                {
                    for (int j = i; j < matrixDataGrid.ColumnCount; j++)
                    {
                        int currentCellValue = int.Parse(matrixDataGrid.Rows[i].Cells[j].Value.ToString());
                        if (currentCellValue >= 0)
                        {
                            if (i == j)
                            {
                                while (currentCellValue > 0)
                                {
                                    edgeCount++;
                                    currentCellValue -= 2;
                                }
                            }
                            else
                            {
                                while (currentCellValue > 0)
                                {
                                    edgeCount++;
                                    currentCellValue--;
                                }
                            }
                        }
                        else
                        {
                            throw new ArgumentException(
                                $"ВВЕДЕНО НЕКОРРЕКТНОЕ ЗНАЧЕНИЕ В ЯЧЕЙКЕ ({i + 1}, {j + 1}) В ЯЧЕЙКЕ МАТРИЦЫ: {currentCellValue}.\n" +
                                $"ДОПУСКАЮТСЯ ТОЛЬКО НЕОТРИЦАТЕЛЬНЫЕ ЗНАЧЕНИЯ.");
                        }
                    }
                }
            }
            catch (FormatException)
            {
                string errorMessage = $"ВВЕДЕНО НЕКОРРЕКТНОЕ ЗНАЧЕНИЕ ";
                MessageBox.Show(errorMessage);
            }
            catch(ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }
            return edgeCount;
        }

        private int getDirectedEdgeCount()
        {
            int edgeCount = 0;

            try
            {
                for (int i = 0; i < matrixDataGrid.RowCount - 1; i++)
                {
                    for (int j = 0; j < matrixDataGrid.ColumnCount; j++)
                    {
                        int currentCellValue = int.Parse(matrixDataGrid.Rows[i].Cells[j].Value.ToString());
                        if (currentCellValue >= 0)
                        {
                            if (i == j)
                            {
                                while (currentCellValue > 0)
                                {
                                    edgeCount++;
                                    currentCellValue -= 2;
                                }
                            }
                            else
                            {
                                while (currentCellValue > 0)
                                {
                                    edgeCount++;
                                    currentCellValue--;
                                }
                            }
                        }
                        else
                        {
                            throw new ArgumentException(
                                $"ВВЕДЕНО НЕКОРРЕКТНОЕ ЗНАЧЕНИЕ В ЯЧЕЙКЕ ({i + 1}, {j + 1}) В ЯЧЕЙКЕ МАТРИЦЫ: {currentCellValue}.\n" +
                                $"ДОПУСКАЮТСЯ ТОЛЬКО НЕОТРИЦАТЕЛЬНЫЕ ЗНАЧЕНИЯ.");
                        }
                    }
                }
            }
            catch (FormatException)
            {
                string errorMessage = $"ВВЕДЕНО НЕКОРРЕКТНОЕ ЗНАЧЕНИЕ ";
                MessageBox.Show(errorMessage);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }
            return edgeCount;
        }

        private void calcUndirectedMatrix()
        {
            int currentEdge = 0;

            for (int i = 0; i < int.Parse(vertexComboBox.SelectedItem.ToString()); i++)
            {
                for (int j = i; j < matrixDataGrid.ColumnCount; j++)
                {
                    int currentCellValue = int.Parse(matrixDataGrid.Rows[i].Cells[j].Value.ToString());
                    while (currentCellValue > 0)
                    {
                        if (i == j)
                        {
                            resultMatrixDataGrid.Rows[i].Cells[currentEdge].Value = 2;
                            currentCellValue -= 2;
                        }
                        else
                        {
                            resultMatrixDataGrid.Rows[i].Cells[currentEdge].Value = 1;
                            resultMatrixDataGrid.Rows[j].Cells[currentEdge].Value = 1;
                            currentCellValue--;
                        }
                        currentEdge++;
                    }
                }
            }
        }

        private void calcDirectedMatrix()
        {
            int currentEdge = 0;

            for (int i = 0; i < int.Parse(vertexComboBox.SelectedItem.ToString()); i++)
            {
                for (int j = 0; j < matrixDataGrid.ColumnCount; j++)
                {
                    int currentCellValue = int.Parse(matrixDataGrid.Rows[i].Cells[j].Value.ToString());
                    while (currentCellValue > 0)
                    {
                        if (i == j)
                        {
                            resultMatrixDataGrid.Rows[i].Cells[currentEdge].Value = "+-1";
                            currentCellValue -= 2;
                        }
                        else
                        {
                            resultMatrixDataGrid.Rows[i].Cells[currentEdge].Value = 1;
                            resultMatrixDataGrid.Rows[j].Cells[currentEdge].Value = -1;
                            currentCellValue--;
                        }
                        currentEdge++;
                    }
                }
            }
        }

        private void calcSetForUndirectedGraph()
        {
            for(int i = 0; i < matrixDataGrid.RowCount - 1; i++)
            {
                List<string> resultVertexList = new List<string>();
                for(int j = 0; j < matrixDataGrid.ColumnCount; j++)
                {
                    if (matrixDataGrid.Rows[i].Cells[j].Value.ToString() != "0")
                        resultVertexList.Add((j + 1).ToString());
                }

                resultSetDataGrid.Rows[i].Cells[0].Value = "{" + string.Join(",", resultVertexList) + "}";
            }
        }

        private void calcSetForDirectedGraph()
        {
            for (int i = 0; i < matrixDataGrid.ColumnCount; i++)
            {
                List<string> resultVertexList = new List<string>();
                for (int j = 0; j < matrixDataGrid.RowCount - 1; j++)
                {
                    if (matrixDataGrid.Rows[j].Cells[i].Value.ToString() != "0")
                        resultVertexList.Add((j + 1).ToString());
                }

                resultSetDataGrid.Rows[i].Cells[0].Value = "{" + string.Join(",", resultVertexList) + "}";
            }
        }

        private void vertexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vertexCount = int.Parse(vertexComboBox.SelectedItem.ToString());
            InitializeMatrix(matrixDataGrid, vertexCount, vertexCount);
        }

        private void matrixCalcButton_Click(object sender, EventArgs e)
        {
            if (!graphCheckBox.Checked)
            {
                InitializeMatrix(resultMatrixDataGrid,
                    int.Parse(vertexComboBox.SelectedItem.ToString()), getUndirectedEdgeCount());
                calcUndirectedMatrix();
            }
            else
            {
                InitializeMatrix(resultMatrixDataGrid, 
                    int.Parse(vertexComboBox.SelectedItem.ToString()), getDirectedEdgeCount());
                calcDirectedMatrix();
            }
        }

        private void setCalcButton_Click(object sender, EventArgs e)
        {
            InitializeMatrix(resultSetDataGrid, int.Parse(vertexComboBox.SelectedItem.ToString()), 1);
            if (!graphCheckBox.Checked)
            {
                calcSetForUndirectedGraph();
            }

            else
            {
                calcSetForDirectedGraph();
            }
        }
    }
}
