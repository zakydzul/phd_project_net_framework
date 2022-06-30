using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace phd_project_net_framework.Costum_Class
{
    public class Job
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Physical_Channel { get; set; }
        public decimal MinVal { get; set; }
        public decimal MaxVal { get; set; }
        public double Rate { get; set; }
        public int Samples { get; set; }
        public double Sensitivity { get; set; }
        public string Sens_Units { get; set; }
        public string Input_Coupling { get; set; }
        public string Terminal_Coupling { get; set; }
        public string Excitation_Source { get; set; }
        public double Excitaion_Val { get; set; }
    }
}
