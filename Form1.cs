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
                //Código que pode lançar um erro proposital
                int[] array = new int[5];
                Console.WriteLine(array[10]); //Isso resultará em um erro pois está fora dos limites do Array
            }
            catch (IndexOutOfRangeException ex)
            {
                //Catch para lidar com o erro
                MessageBox.Show("O Vetor do array não existe: " + ex.Message);
            }
            finally
            {
                //O Finally que será executado sempre, independentemente de houver erros ou não
                MessageBox.Show("Finally executado.");
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            ForceTryCatch();
        }
    }
}
