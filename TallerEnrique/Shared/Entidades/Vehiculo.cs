﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEnrique.Shared.Entidades
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre de la marca  es Obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El Número del modelo  es Obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "El Color  es Obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string Color { get; set; }

        [Required(ErrorMessage = "El Número de la Placa  es Obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string Placa { get; set; }

        [Required(ErrorMessage = "La Fecha de Entrada es Obligatorio ")]
        public DateTime FechaEntrada { get; set; }

        [Required(ErrorMessage = "La fecha de salida es obligatorio ")]
        public DateTime FechaSalida { get; set; }

        [Required(ErrorMessage = "El Año es obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public int YearCar { get; set; }

        [Required(ErrorMessage = "El Kilometraje  es obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string Kilometraje { get; set; }
        public bool Estado { get; set; }
    }
}