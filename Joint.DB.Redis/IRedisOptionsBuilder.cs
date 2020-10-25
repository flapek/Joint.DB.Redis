namespace Joint.DBRedis
{
    public interface IRedisOptionsBuilder
    {
        IRedisOptionsBuilder WithConnectionString(string connectionString);
        IRedisOptionsBuilder WithInstance(string instance);
        RedisOptions Build();
    }
}