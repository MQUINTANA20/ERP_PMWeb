//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_SDMMatto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class manttomovequipo
    {
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public string EquipoD { get; set; }
        public Nullable<int> Empresa { get; set; }
        public Nullable<int> DesgasteAnteriorD { get; set; }
        public Nullable<int> DesgasteActualD { get; set; }
        public Nullable<System.DateTime> UltimoMantenimiento { get; set; }
        public Nullable<int> UltimoMantenimientoDesgaste { get; set; }
        public Nullable<System.DateTime> Antiguedad { get; set; }
        public Nullable<int> DesgasteTeorico { get; set; }
        public Nullable<int> DesgasteTeoricoAnterior { get; set; }
    
        public virtual manttoequipo manttoequipo { get; set; }
    }
}
