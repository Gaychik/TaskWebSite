using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for Matrix
/// </summary>
public class Matrix
{
    public Matrix(out int[,] mas,int row,int col)
    {
        mas = new int[row, col];
        for (int i = 0; i < mas.GetLength(0); i++)
            for (int j = 0; j < mas.GetLength(1); j++)
                mas[i, j] = -1;


    }
}