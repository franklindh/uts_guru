namespace Guru.Models
{
    public class GuruItem
    {
        private GuruContext _context;
        public int id { get; set; }
        public string rfid { get; set; }
        public string nip { get; set; }
        public string nama_guru { get; set; }
        public string alamat { get; set; }
        public int status_guru { get; set; }

    }
}
