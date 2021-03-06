﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepeaterSamples._04_Main_Details
{
    public partial class _01_SelectedIndexChanged : System.Web.UI.Page
    {

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получение порядкового номера строки.
            int index = GridView1.SelectedIndex;

            // Ключевое поле извлекается из свойства SelectedDataKey.
            int ID = (int)GridView1.SelectedDataKey.Values["EmployeeID"];

            // Другие данные можно извлечь непосредственно из коллекции Cells,
            // если известно смещение столбца.
            string firstName = GridView1.SelectedRow.Cells[2].Text;
            string lastName = GridView1.SelectedRow.Cells[3].Text;

            Output.Text = string.Format("Индекс выбранной строки {0}<br /> ID элемента {1} <br /> First Name = {2} <br /> Last Name = {3}", index, ID, firstName, lastName);
        }
    }
}