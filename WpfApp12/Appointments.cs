//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp12
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointments
    {
        public int ID_Appointment { get; set; }
        public int Patient_ID { get; set; }
        public int Doctor_ID { get; set; }
        public System.DateTime DateAppointment { get; set; }
        public string DescriptionAppointment { get; set; }
    
        public virtual Doctors Doctors { get; set; }
        public virtual Patients Patients { get; set; }
    }
}
