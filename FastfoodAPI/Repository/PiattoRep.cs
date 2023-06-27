using FastFoodAPI.Model;

namespace FastFoodAPI.Repository
{
    public class PiattoRep
    {
        private FastFoodContext _context;
        public PiattoRep(FastFoodContext context)
        {
            _context = context;
        }

        public List <Piatto> findAll()
        {
            List<Piatto> list = _context.Piatto.ToList();
            return list;
        }

        public Piatto findById(int id)
        {
            Piatto piatto = _context.Piatto.Find(id);
            if (piatto == null) return null;
            return piatto;
        }

        public Piatto save(Piatto saving)
        {
            _context.Piatto.Update(saving);
            int result = _context.SaveChanges();
            if (result <= 0) return null;
            return saving;
        }

        public bool delete(int id) 
        {
            Piatto piatto = _context.Piatto.Find(id);
            if (piatto == null) return false;
            _context.Remove(piatto);
            int result = _context.SaveChanges();
            return result > 0;
        }
    }
}
