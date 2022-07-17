using Microsoft.EntityFrameworkCore;


public class Contexto : DbContext
{
    public DbSet<Coins> Coins { get; set; }

    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 1,
            Descripcion = "Bitcoin",
            Valor = 21295.8,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/bitcoin.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 2,
            Descripcion = "Ethereum",
            Valor = 1347.44,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/ethereum.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 3,
            Descripcion = "Solana",
            Valor = 39.807,
            ImageUrl = "https://cryptologos.cc/logos/solana-sol-logo.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 4,
            Descripcion = "Binance",
            Valor = 1.0002,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/binance-usd.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 5,
            Descripcion = "Shiba Inu",
            Valor = 0.00001099,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/shiba-inu.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 6,
            Descripcion = "Cardano",
            Valor = 0.4525,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/cardano.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 7,
            Descripcion = "Uniswap",
            Valor = 7.2902,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/uniswap.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 8,
            Descripcion = "Chainlink",
            Valor = 6.49,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/chainlink.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 9,
            Descripcion = "Aave",
            Valor = 91.10,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/aave.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 10,
            Descripcion = "Bitcoin Cash",
            Valor = 109.10,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/bitcoin-cash.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 11,
            Descripcion = "Flow",
            Valor = 1.5890,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/flow.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 12,
            Descripcion = "Decentraland",
            Valor = 0.8598,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/decentraland.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 13,
            Descripcion = "Internet Computer",
            Valor = 7.08,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/internet-computer.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 14,
            Descripcion = "Pax Dollar",
            Valor = 1.0003,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/paxos-standard.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 15,
            Descripcion = "Zcash",
            Valor = 63.17,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/zcash.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 16,
            Descripcion = "The Graph",
            Valor = 0.10077,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/the-graph.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 17,
            Descripcion = "Chiliz",
            Valor = 0.1107,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/chiliz.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 18,
            Descripcion = "Neo",
            Valor = 9.2603	,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/neo.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 19,
            Descripcion = "Curve DAO Token",
            Valor = 1.1812,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/curve-dao-token.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 20,
            Descripcion = "Mina",
            Valor = 0.685,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/mina.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 21,
            Descripcion = "PancakeSwap",
            Valor = 3.251,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/pancakeswap.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 22,
            Descripcion = "NEM",
            Valor = 0.04203,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/nem.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 23,
            Descripcion = "Kava.io",
            Valor = 1.7520,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/kava.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 24,
            Descripcion = "Basic Attention Token",
            Valor = 0.39558,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/basic-attention-token.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins()
        {
            MonedaId = 25,
            Descripcion = "Maker",
            Valor = 960.58,
            ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/maker.png"
        });

    }
}
