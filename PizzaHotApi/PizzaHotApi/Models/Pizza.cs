﻿using PizzaHotApi.Data;
namespace PizzaHotApi.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }
    }
}
