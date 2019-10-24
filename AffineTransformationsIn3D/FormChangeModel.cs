using AffineTransformationsIn3D.Geometry;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AffineTransformationsIn3D
{
    public partial class FormChangeModel : Form
    {
        public Mesh SelectedModel { get; private set; }

        private Camera _this_camera;

        public FormChangeModel(Camera this_camera)
        {
            InitializeComponent();
            _this_camera = this_camera;
        }

        private void Ok(object sender, EventArgs e)
        {
            var tab = tabControl1.SelectedTab;
            if (tabPagePolyhedron == tab)
            {
                if (radioButtonTetrahedron.Checked)
                    SelectedModel = Models.Tetrahedron(0.5);
                else if (radioButtonIcosahedron.Checked)
                    SelectedModel = Models.Icosahedron(0.5);
                else if (radioButtonCube.Checked)
                    SelectedModel = Models.Cube(0.5);
            }

        }
    }
}
