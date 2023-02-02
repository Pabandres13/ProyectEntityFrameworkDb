using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

//creation table Tarea
namespace proyectoef.Models
{
    public class Tarea
    {
        [Key]
        public Guid TareaId {get;set;}

        [ForeignKey("CategoriaId")]
        public Guid CatergoriaId {get;set;}

        [Required]
        [MaxLength(200)]
        public string Titulo {get;set;}

        public string Descripcion {get;set;}

        public Prioridad PrioridadTarea {get;set;}

        public DateTime FechaCreacion {get;set;}

        public virtual Categoria categoria {get;set;}

        [NotMapped]
        public string Resumen {get;set;}
    }
}

public enum Prioridad
{
    baja,
    media,
    alta
}
