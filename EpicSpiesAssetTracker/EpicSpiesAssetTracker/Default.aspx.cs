using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetName = new string[0];
                ViewState.Add("AssetNameKey", assetName);

                int[] electionsRigged = new int[0];
                ViewState.Add("ElectionsKey", electionsRigged);

                int[] subterfugePerformed = new int[0];
                ViewState.Add("SubterfugeKey", subterfugePerformed);
            }
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            string[] assetName = (string[]) ViewState["AssetNameKey"];
            Array.Resize(ref assetName, assetName.Length + 1);
            int newestAssestName = assetName.GetUpperBound(0);
            assetName[newestAssestName] = assetNameTextBox.Text;
            ViewState["AssetNameKey"] = assetName;

            int[] electionsRigged = (int[]) ViewState["ElectionsKey"];
            Array.Resize(ref electionsRigged, electionsRigged.Length + 1);
            int newestElection = electionsRigged.GetUpperBound(0);
            electionsRigged[newestElection] = int.Parse(electionsRiggedTextBox.Text);
            ViewState["ElectionsKey"] = electionsRigged;

            int[] subterfugePerformed = (int[]) ViewState["SubterfugeKey"];
            Array.Resize(ref subterfugePerformed, subterfugePerformed.Length + 1);
            int newestAct = subterfugePerformed.GetUpperBound(0);
            subterfugePerformed[newestAct] = int.Parse(subterfugeTextBox.Text);
            ViewState["SubterfugeKey"] = subterfugePerformed;


            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br/> Average Acts of Subterfuge: {1:N2}<br/> (Last Asset You Added: {2})", electionsRigged.Sum(), subterfugePerformed.Average(), assetName.Last());

            assetNameTextBox.Text = "";
            electionsRiggedTextBox.Text = "";
            subterfugeTextBox.Text = ""; 

        }

    }
}