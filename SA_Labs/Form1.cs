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
            edgeComboBox.SelectedItem = "1";

            SetMatrixSize();
        }

        private void SetMatrixSize()
        {
            int vertexCount = vertexComboBox.SelectedItem == null ? 1 : 
                int.Parse(vertexComboBox.SelectedItem.ToString());

            int edgeCount = edgeComboBox.SelectedItem == null ? 1 :
                int.Parse(edgeComboBox.SelectedItem.ToString());

            InitializeMatrix(matrixDataGrid, vertexCount, edgeCount);
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

        private void calcUndirectedMatrix()
        {
            for (int i = 0; i < int.Parse(vertexComboBox.SelectedItem.ToString()); i++)
            {
                for (int j = 0; j < int.Parse(edgeComboBox.SelectedItem.ToString()); j++)
                {
                    string currentCellValue = matrixDataGrid.Rows[i].Cells[j].Value.ToString();
                    switch(currentCellValue)
                    {
                        case "1":
                            for (int k = 0; k < int.Parse(vertexComboBox.SelectedItem.ToString()); k++)
                            {
                                if (i != k && matrixDataGrid.Rows[k].Cells[j].Value.ToString() == "1")
                                {
                                    int currentValue = int.Parse(resultMatrixDataGrid.Rows[i].Cells[k].Value.ToString());
                                    resultMatrixDataGrid.Rows[i].Cells[k].Value = currentValue + 1;
                                }
                            }
                            break;
                        case "2":
                            {
                                int currentValue = int.Parse(resultMatrixDataGrid.Rows[i].Cells[i].Value.ToString());
                                resultMatrixDataGrid.Rows[i].Cells[i].Value = currentValue + 2;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void calcDirectedMatrix()
        {
            for (int i = 0; i < int.Parse(vertexComboBox.SelectedItem.ToString()); i++)
            {
                for (int j = 0; j < int.Parse(edgeComboBox.SelectedItem.ToString()); j++)
                {
                    string currentCellValue = matrixDataGrid.Rows[i].Cells[j].Value.ToString();
                    switch (currentCellValue)
                    {
                        case "1":
                            for (int k = 0; k < int.Parse(vertexComboBox.SelectedItem.ToString()); k++)
                            {
                                if (i != k && matrixDataGrid.Rows[k].Cells[j].Value.ToString() == "-1")
                                {
                                    int currentValue = int.Parse(resultMatrixDataGrid.Rows[i].Cells[k].Value.ToString());
                                    resultMatrixDataGrid.Rows[i].Cells[k].Value = currentValue + 1;

                                    break;
                                }
                            }
                            break;
                        case "+-1":
                            {
                                int currentValue = int.Parse(resultMatrixDataGrid.Rows[i].Cells[i].Value.ToString());
                                resultMatrixDataGrid.Rows[i].Cells[i].Value = currentValue + 2;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void calcSetForUndirectedGraph()
        {
            for(int i = 0; i < matrixDataGrid.RowCount - 1; i++)
            {
                HashSet<string> resultVertexSet = new HashSet<string>();
                for(int j = 0; j < matrixDataGrid.ColumnCount; j++)
                {
                    string currentValue = matrixDataGrid.Rows[i].Cells[j].Value.ToString();
                    if (currentValue == "1")
                    {
                        for (int k = 0; k < int.Parse(vertexComboBox.SelectedItem.ToString()); k++)
                        {
                            if (i != k && matrixDataGrid.Rows[k].Cells[j].Value.ToString() == "1")
                            {
                                resultVertexSet.Add((k + 1).ToString());
                                break;
                            }
                        }
                    }
                    else if(currentValue == "2")
                    {
                        resultVertexSet.Add((i + 1).ToString());
                    }
                }

                resultSetDataGrid.Rows[i].Cells[0].Value = "{" + string.Join(",", resultVertexSet) + "}";
            }
        }

        private void calcSetForDirectedGraph()
        {
            for (int i = 0; i < matrixDataGrid.RowCount - 1; i++)
            {
                List<string> resultVertexList = new List<string>();
                for (int j = 0; j < matrixDataGrid.ColumnCount; j++)
                {
                    string currentValue = matrixDataGrid.Rows[i].Cells[j].Value.ToString();
                    if (currentValue == "-1")
                    {
                        for (int k = 0; k < int.Parse(vertexComboBox.SelectedItem.ToString()); k++)
                        {
                            if (matrixDataGrid.Rows[k].Cells[j].Value.ToString() == "1")
                            {
                                resultVertexList.Add((k + 1).ToString());
                                break;
                            }
                        }
                    }
                    else if(currentValue == "+-1")
                    {
                        resultVertexList.Add((i + 1).ToString());
                    }
                }

                resultSetDataGrid.Rows[i].Cells[0].Value = "{" + string.Join(",", resultVertexList) + "}";
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMatrixSize();
        }

        private void matrixCalcButton_Click(object sender, EventArgs e)
        {
            InitializeMatrix(resultMatrixDataGrid,
                    int.Parse(vertexComboBox.SelectedItem.ToString()),
                    int.Parse(vertexComboBox.SelectedItem.ToString()));

            if (!graphCheckBox.Checked)
            {
                calcUndirectedMatrix();
            }
            else
            {
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
