﻿// <auto-generated />
using System;
using CryptoApiapl2.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoApiapl2.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("CryptoApiapl2.Models.Coins", b =>
                {
                    b.Property<int>("MonedaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("MonedaId");

                    b.ToTable("Coins");

                    b.HasData(
                        new
                        {
                            MonedaId = 1,
                            Descripcion = "Bitcoin",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/Bitcoin.svg/1024px-Bitcoin.svg.png",
                            Valor = 23000.0
                        },
                        new
                        {
                            MonedaId = 2,
                            Descripcion = "Ethereum",
                            ImageUrl = "https://e7.pngegg.com/pngimages/471/910/png-clipart-ethereum-classic-computer-icons-cryptocurrency-symbol-symbol-miscellaneous-blue.png",
                            Valor = 1233.0
                        },
                        new
                        {
                            MonedaId = 3,
                            Descripcion = "Solana",
                            ImageUrl = "https://cryptologos.cc/logos/solana-sol-logo.png",
                            Valor = 41.979999999999997
                        },
                        new
                        {
                            MonedaId = 4,
                            Descripcion = "Binance",
                            ImageUrl = "https://w7.pngwing.com/pngs/286/459/png-transparent-binance-cryptocurrency-exchange-coin-trade-coin-thumbnail.png",
                            Valor = 17.969999999999999
                        },
                        new
                        {
                            MonedaId = 5,
                            Descripcion = "Shiba Inu",
                            ImageUrl = "https://w7.pngwing.com/pngs/929/384/png-transparent-shib-coin-shib-coin-logo-shiba-token-thumbnail.png",
                            Valor = 1.2E-05
                        },
                        new
                        {
                            MonedaId = 6,
                            Descripcion = "Cardano",
                            ImageUrl = "https://w7.pngwing.com/pngs/844/873/png-transparent-cardano-zug-cryptocurrency-blockchain-ethereum-bitcoin-wallet-thumbnail.png",
                            Valor = 0.5
                        },
                        new
                        {
                            MonedaId = 7,
                            Descripcion = "Uniswap",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Uniswap_Logo.svg/1026px-Uniswap_Logo.svg.png",
                            Valor = 50245.0
                        },
                        new
                        {
                            MonedaId = 8,
                            Descripcion = "Chainlink",
                            ImageUrl = "https://cryptologos.cc/logos/chainlink-link-logo.png",
                            Valor = 7.2300000000000004
                        },
                        new
                        {
                            MonedaId = 9,
                            Descripcion = "Ripple",
                            ImageUrl = "https://flyclipart.com/thumb2/ripple-xrp-icon-242793.png",
                            Valor = 36671.0
                        },
                        new
                        {
                            MonedaId = 10,
                            Descripcion = "Bitcoin Cash",
                            ImageUrl = "https://logodownload.org/wp-content/uploads/2021/01/bitcoin-cash-logo-5.png",
                            Valor = 117.47
                        });
                });
#pragma warning restore 612, 618
        }
    }
}