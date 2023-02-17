﻿using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace RapiD.Geometry.Models
{
   public partial class Torus3D : GeometryBase3D
    {

        [ObservableProperty]
        double diameter = 150;

        [ObservableProperty]
        double tubeDiameter = 30;

        [ObservableProperty]
        int thetaDiv  = 100;

        [ObservableProperty]
        int phiDiv = 100;

        [ObservableProperty]
        double offSetX;

        [ObservableProperty]
        double offSetY;


        [ObservableProperty]
        double offSetZ;



        public Torus3D(double diam, double tubeDiam,Vector3 pos)
        {
            Position = pos;

            this.diameter = diam;
            this.tubeDiameter = tubeDiam;

            // Assing model material
            OriginalMaterial = PhongMaterials.Green;

            Draw();

        }


         



        public override void Draw()
        {
            // Create triangle mesh for an 3d sphere
            MeshBuilder meshBuilder = new MeshBuilder();
            meshBuilder.AddTorus(diameter, tubeDiameter, thetaDiv, phiDiv);
            // Assign mesh to model
            MeshGeometry = meshBuilder.ToMeshGeometry3D();


        }
    }
}
