﻿using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using SharpDX;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapiD.Geometry.Models
{
    public partial class Squared3D : GeometryBase3D
    {



        public Vector3 Size { get; set; }
     
        
        public Squared3D(Vector3 position,Vector3 size)
        {
            OriginalMaterial = PhongMaterials.Blue;
            Position= position;
            Size = size;
            Name = "Squared Box";       
            Draw();
        }


        public override void Draw()
        {
            MeshBuilder meshBuilder = new MeshBuilder();

            meshBuilder.AddBox(Position,Size.X,Size.Y,Size.Z);
            
            MeshGeometry = meshBuilder.ToMeshGeometry3D();
        }
    }
}
