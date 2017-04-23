using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using HtmlAgilityPack;


namespace maxscriptReferenceParser
{
    public partial class Form1 : Form
    {

        public string[] htmFilenames = new string[] { };
        public List<List<string>> categoryLinks = new List<List<string>>{};


        public Form1()
        {
            InitializeComponent();
        }


        private string parseFiles( string[] filenames )
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            StringBuilder sb = new StringBuilder();

           

            foreach ( string filename in filenames )
            {

                string docString = File.ReadAllText( filename );

                doc.LoadHtml( docString );

                //HtmlNodeCollection codeBlocks = doc.DocumentNode.SelectNodes( "//div[@class='section']/div[@class='codeBlock']" );
                HtmlNodeCollection codeBlocks = doc.DocumentNode.SelectNodes( "//div[@class='codeBlock']" );


                if ( codeBlocks == null ) continue;

                foreach ( HtmlNode node in codeBlocks )
                {
                    if ( node.ParentNode.Name == "td" ) continue;

                    sb.Append( node.InnerText + "\n" );

                }



            }

            string result = sb.ToString();
            result = result.Replace( "&lt;", "<" );
            result = result.Replace( "&gt;", ">" );
            result = result.Replace( "&amp;", "&" );
            

            return result;

        }

        private void getCategories() {

            string docString = File.ReadAllText( mxsPathTextbox.Text + "/scripts/search-data.js" );

            docString = System.Text.RegularExpressions.Regex.Replace( docString, "},\n{\"title", "},~\n{\"title" );

            string[] items = docString.Split( new string[] { "~" }, StringSplitOptions.None );

            // Get all base reference categories
            List<string> categories = new List<string> { };
            foreach ( string item in items )
            {

                if ( item.Contains( "[]" ) )
                {

                    string categoryName = System.Text.RegularExpressions.Regex.Match( item, "title\":\"([^\"]+)" ).Groups[1].Value;

                    categories.Add( categoryName );

                }

            }
            mxsCategoriesListbox.Items.AddRange( categories.ToArray() );



            // sort links by categories
            int index = 0;
            foreach ( string cat in categories )
            {

                categoryLinks.Add( new List<string> { } );

                foreach ( string item in items )
                {

                    if ( item.Contains( cat ) )
                    {
                        string href = System.Text.RegularExpressions.Regex.Match( item, "href\":\".(/files/[^\"]+)" ).Groups[1].Value;
                        categoryLinks[index].Add( mxsPathTextbox.Text + href );

                    }


                }

                index++;

            }


        }

        

        private void parseWholeReferenceBtn( object sender, EventArgs e )
        {
            
            richTextBox1.Text = parseFiles( htmFilenames );
            

        }

        private void parseSelectedCategories( object sender, EventArgs e )
        {

            richTextBox1.Text = "";
            
            foreach ( int index in mxsCategoriesListbox.SelectedIndices )
            {
                
                /*
                foreach ( string link in categoryLinks[ index ] )
                {

                    richTextBox1.Text += link + "\n";


                }*/

                richTextBox1.Text += parseFiles( categoryLinks[index].ToArray() );



            }


        }

        private void mxsPathTextbox_TextChanged( object sender, EventArgs e )
        {
            
            string path = mxsPathTextbox.Text;

            if ( Directory.Exists( path ) ) {

                if ( Directory.Exists( path + "/files" ) && Directory.Exists( path + "/scripts" ) ) {

                    if ( File.Exists( path + "/scripts/search-data.js" ) ) {

                        htmFilenames = Directory.GetFiles( path + "/files", "*.htm" );

                        mxsPathTextbox.Enabled = false;
                        richTextBox1.Enabled = button1.Enabled = button3.Enabled = mxsCategoriesListbox.Enabled = true;

                        getCategories();


                    }
                }

            }
            

        }
    }
}
