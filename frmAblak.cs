using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllapotsorValasztogomb
{
  /// <summary>
  /// Felsorolás típus a panelek neveinek tárolására.
  /// </summary>
  public enum PanelSorszámok
  {
    Második = 1,
    Harmadik,
    Negyedik,
  }
  /// <summary>
  /// Bemutatja az állapotsor használatát.
  /// </summary>
  public partial class frmAblak : Form
  {
    PanelSorszámok PanelSorszám;
    public frmAblak()
    {
      InitializeComponent();
      //
      // Kezdetben a második panelt választjuk ki
      //
      PanelSorszám = PanelSorszámok.Második;
      rbMásodik.Checked = true;
      tIdőzítő.Start();
    }
    private void btBeír_Click(object sender, EventArgs e)
    {
      ssÁllapotSor.Items[(int)PanelSorszám].Text =
        tbSzöveg.Text;
    }

    private void frmAblak_FormClosing(object sender,
      FormClosingEventArgs e)
    {
      tIdőzítő.Stop();
      e.Cancel = true;
    }

    /// <summary>
    /// Ha megváltozik a kiválasztott panel, akkor az
    /// újat eltároljuk a PanelSorszám adattagban
    /// </summary>
    /// <param name="sender">Az eseményt előidéző váklasztógomb</param>
    /// <param name="e">Az esemény paraméterei</param>
    private void rb_CheckedChanged(object sender, EventArgs e)
    {
      if ((RadioButton)sender == rbMásodik)
        PanelSorszám = PanelSorszámok.Második;
      else
        if ((RadioButton)sender == rbHarmadik)
        PanelSorszám = PanelSorszámok.Harmadik;
      else
          if ((RadioButton)sender == rbNegyedik)
        PanelSorszám = PanelSorszámok.Negyedik;
    }


    private void tIdőzítő_Tick(object sender, EventArgs e)
    {
      DateTime Dt = DateTime.Now;
      string Felirat = Dt.Hour.ToString("00") + ":" +
        Dt.Minute.ToString("00") + ":" +
        Dt.Second.ToString("00");
      tssElső.Text = Felirat;
    }
  }

}
