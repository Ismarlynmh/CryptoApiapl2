using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCrypto.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    MonedaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<double>(type: "REAL", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.MonedaId);
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 1, "Bitcoin", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/bitcoin.png", 21295.799999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 2, "Ethereum", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/ethereum.png", 1347.4400000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 3, "Solana", "https://cryptologos.cc/logos/solana-sol-logo.png", 39.807000000000002 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 4, "Binance", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/binance-usd.png", 1.0002 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 5, "Shiba Inu", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/shiba-inu.png", 1.099E-05 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 6, "Cardano", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/cardano.png", 0.45250000000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 7, "Uniswap", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/uniswap.png", 7.2901999999999996 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 8, "Chainlink", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/chainlink.png", 6.4900000000000002 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 9, "Aave", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/aave.png", 91.099999999999994 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 10, "Bitcoin Cash", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/bitcoin-cash.png", 109.09999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 11, "Flow", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/flow.png", 1.589 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 12, "Decentraland", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/decentraland.png", 0.85980000000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 13, "Internet Computer", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/internet-computer.png", 7.0800000000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 14, "Pax Dollar", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/paxos-standard.png", 1.0003 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 15, "Zcash", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/zcash.png", 63.170000000000002 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 16, "The Graph", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/the-graph.png", 0.10077 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 17, "Chiliz", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/chiliz.png", 0.11070000000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 18, "Neo", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/neo.png", 9.2603000000000009 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 19, "Curve DAO Token", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/curve-dao-token.png", 1.1812 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 20, "Mina", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/mina.png", 0.68500000000000005 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 21, "PancakeSwap", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/pancakeswap.png", 3.2509999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 22, "NEM", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/nem.png", 0.042029999999999998 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 23, "Kava.io", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/kava.png", 1.752 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 24, "Basic Attention Token", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/basic-attention-token.png", 0.39557999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 25, "Maker", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/maker.png", 960.58000000000004 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coins");
        }
    }
}
