namespace netcore.produtos.model{

    public class Produto{

        private long id;

        private string nome;

        private int quantidade;

        private float valor;

        public long Id{
            get{
                return this.id;
            }
            set{
                this.id=value;
            }
        }
        public string Nome{
            get{
                return this.nome;
            }
            set{
                this.nome=value;
            }
        }
        public int Quantidade{
            get{
                return this.quantidade;
            }
            set{
                this.quantidade=value;
            }
        }

        public float Valor{
            get{
                return this.valor;
            }
            set{
                this.valor=value;
            }
        }            
    } 



}