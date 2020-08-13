class Install
{
    private readonly Logger _logger;
    public Install(Logger logger)
    {
        _logger = logger;
    }
    public void _Install()
    {
        _logger.Log("Installing");
    }
}