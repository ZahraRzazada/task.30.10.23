using Classwork._26._10._23.Models;
using Classwork._26._10._23.Services.Abstract;


namespace Classwork._26._10._23.Services.Concrete
{
    public class AppDataContext: IAppDataContext
	{
        private readonly List<Marka> _marka;
        public List<Marka> Marka { get; }

        public AppDataContext()
		{
            _marka = new List<Marka>()
            {
                new Marka{Name= "Audi" ,Id=1},
                new Marka{Name= "BMW" ,Id=2},
                new Marka{Name= "Chryseler" ,Id=3},
                new Marka{Name= "Nissan" ,Id=4},
                new Marka{Name= "Mercedes" ,Id=5},
                new Marka{Name= "Volvo" ,Id=6},

            };
            Marka = _marka;

        }
	}
}

