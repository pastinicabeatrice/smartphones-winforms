using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones
{
    public class Smartphone
    {
        public int Id {  get; set; }    
        public string Model {  get; set; }
        public int UnitatiPeStoc {  get; set; }
        public decimal Pret {  get; set; }
        public DateTime DataAparitiei { get; set; }
        public int IdProducator {  get; set; }
    }
}
