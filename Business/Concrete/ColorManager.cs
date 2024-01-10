using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
namespace Business.Concrete
{
    public class ColorManager : IColorManager
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetByColorId(int id)
        {
            return _colorDal.GetAll(c => c.ColorId == id);
        }

        public Color GetById(int id)
        {
            return _colorDal.GetById(c => c.ColorId == id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
