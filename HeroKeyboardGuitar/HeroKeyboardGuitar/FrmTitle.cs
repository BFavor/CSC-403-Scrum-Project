﻿using System;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;

internal partial class FrmTitle : UserControl
{
    public ScreenSwapHandler handler;
    public FrmTitle()
    {
        InitializeComponent();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        FrmSongSelect frmSongSelect = new();
        frmSongSelect.Show();
    }

    private void FrmTitle_Load(object sender, EventArgs e)
    {
        /*
        btnStart.Left = Width / 2 - btnStart.Width / 2;
        btnStart.Top = (int)(Height * 0.65);
        */
    }

    private void btn_startClicked(object sender, EventArgs e)
    {
        handler.gotoSongSelect();
    }

    private void btn_songManageClicked(object sender, EventArgs e)
    {
        handler.gotoSongManage();
    }

    private void btn_settingsClicked(object sender, EventArgs e)
    {
       
    }

    private void btn_quitClicked(object sender, EventArgs e)
    {
           
    }
}
