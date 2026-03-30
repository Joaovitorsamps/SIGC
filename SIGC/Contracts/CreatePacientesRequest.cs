namespace SIGC.Contracts
{
    public class CreatePacientesRequest
    {
        public string CPF_Paciente {  get; set; }
        public string Nome { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
    }
}
