using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash.Models
{
    public class CashItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public double TotalEfectivoMes { get; set; }
        public string FechaRegistrado { get; set; }
    }
}
