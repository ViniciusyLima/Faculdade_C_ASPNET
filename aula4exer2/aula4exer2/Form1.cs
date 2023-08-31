using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4exer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Load("../../Resources/argentina.jpg");
            textBox1.Text = "A Argentina é uma nação sul-americana situada ao sul do continente. É uma região que, assim como o Brasil, foi colonizada, no caso, pelos espanhóis. Sua geografia é bastante diversificada, envolve um mosaico de diferentes climas e vegetações e possibilita que seja um grande produtora de alimentos. É também um país populoso, considerado uma economia emergente, com elevada qualidade de vida, além de que sua população desfruta de uma infraestrutura bastante moderna.\nFoi colonizada pelos espanhóis durante o período das Grandes Navegações. Sua independência ocorreu em 1861.";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Load("../../Resources/brasil.jpg");
            textBox1.Text = "\"O Brasil é o maior país da América do Sul, com área de mais de 8,5 milhões de km². Tem como capital a cidade de Brasília. Apresenta uma grande variedade climática e paisagística, que pode ser analisada mediante os domínios morfoclimáticos.\r\n\r\nA população brasileira chegou a 213.317.639 habitantes em 2021, de acordo com o IBGE, com mais de 87% dela vivendo nas cidades. São Paulo, capital do estado de mesmo nome, constitui a maior área urbana do Brasil, com 12 milhões de habitantes.\r\n\r\nA economia brasileira, embora liderada pelo setor terciário, se destaca também em áreas como a indústria petroquímica e automobilística e na produção agropecuária, que tem a soja como carro-chefe.";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Load("../../Resources/chile.jpg");
            textBox1.Text = "\"Segundo os historiadores e arqueólogos, os primeiros grupos humanos estabeleceram-se no Chile de 10 mil a 15 mil anos atrás. Naturalmente, em princípio, os grupos humanos na região do Chile eram nômades que foram sedentarizando-se à medida que seu estilo de vida sofisticou-se e adaptou-se às mudanças climáticas que aconteceram naquela região.\r\n\r\nO território chileno foi ocupado por uma série de povos pré-colombianos, dos quais se destacaram os atacamenhos, aimarás, onawos, changos etc. Na ilha de Páscoa, localizada no meio do Oceano Pacífico, desenvolveu-se uma civilização polinésia conhecida como rapa nui, que foi responsável por uma construção muito famosa, os moais.";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Load("../../Resources/russia.png");
            textBox1.Text = "\"A Rússia é o maior país do mundo em extensão territorial, localizando-se em dois continentes: Europa e Ásia. Apesar de ser uma das nações mais populosas do planeta, dispõe de baixa densidade demográfica. Um dos climas predominantes no país é o Continental Úmido, com áreas de ocorrência de clima Polar. Seu relevo se divide entre planícies e planaltos e abriga a maior elevação da Europa: o monte Elbrus. O país é um dos principais produtores e exportadores de petróleo e gás natural do mundo.";
        }
    }
}