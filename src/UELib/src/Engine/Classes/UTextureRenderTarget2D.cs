﻿using UELib.Branch;

namespace UELib.Engine
{
    /// <summary>
    ///     Implements UTextureRenderTarget2D/Engine.TextureRenderTarget2D
    /// </summary>
    [UnrealRegisterClass]
    [BuildGeneration(BuildGeneration.UE3)]
    public class UTextureRenderTarget2D : UTexture
    {
        public uint SizeX, SizeY;

        protected override void Deserialize()
        {
            base.Deserialize();

            if (_Buffer.Version < (uint)PackageObjectLegacyVersion.DisplacedUTextureProperties)
            {
                _Buffer.Read(out SizeX);
                Record(nameof(SizeX), SizeX);
                _Buffer.Read(out SizeY);
                Record(nameof(SizeY), SizeY);

                _Buffer.Read(out int format);
                Format = (TextureFormat)format;
                Record(nameof(Format), Format);

                _Buffer.Read(out int numMips);
                Record(nameof(numMips), numMips);
            }
        }
    }
}
