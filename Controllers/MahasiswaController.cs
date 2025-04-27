using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300021;

namespace tpmodul10_103022300021.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Naufal Dzulfikar", "103022300021"),
            new Mahasiswa("LeBron James", "1302000001"),
            new Mahasiswa("Stephen Curry", "1302000002"),
            new Mahasiswa("Kevin Durant", "1302000003")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}
