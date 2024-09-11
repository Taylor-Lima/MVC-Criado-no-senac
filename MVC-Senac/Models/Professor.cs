namespace MVC_Senac.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public string Sala { get; set; }
    }
}

//create table professor(
//id int identity(1,1) not null,
//nome varchar(40),
//disciplina varchar(20),
//sala varchar(15),
//primary key(id)
//)