using FastFoodAPI.Model;

namespace FastFoodAPI.Repository
{
    public class ClienteRep
    {
        private FastFoodContext _context;

        public ClienteRep(FastFoodContext context)
        {
            _context = context;
        }

        public List<Cliente> findAll()
        {
            List<Cliente> list = _context.Cliente.ToList();
            return list;
        }

        public Cliente FindById(int id)
        {
            Cliente cliente = _context.Cliente.Find(id);
            if (cliente == null) return null;
            return cliente;
        }

        public Cliente save(Cliente saving)
        {
            _context.Cliente.Update(saving);
            _context.SaveChanges();
            return saving;
        }

        public bool delete(int id)
        {
            Cliente cliente = _context.Cliente.Find(id);

            if (cliente == null) return false;

            _context.Remove(cliente);
            int result = _context.SaveChanges();
            return result > 0;
        }
    }
}
