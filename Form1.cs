namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ForceTryCatch()
        {
            try
            {
                //C�digo que pode lan�ar um erro proposital
                int[] array = new int[5];
                Console.WriteLine(array[10]); //Isso resultar� em um erro pois est� fora dos limites do Array
            }
            catch (IndexOutOfRangeException ex)
            {
                //Catch para lidar com o erro
                MessageBox.Show("O Vetor do array n�o existe: " + ex.Message);
            }
            finally
            {
                //O Finally que ser� executado sempre, independentemente de houver erros ou n�o
                MessageBox.Show("Finally executado.");
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            ForceTryCatch();
        }
    }
}
