using System;
using NUnit.Framework;

public class HeroRepositoryTests
{
    [SetUp]
    public void Start()
    {
        Hero hero = new Hero("Test", 15);
        HeroRepository heroRepository = new HeroRepository();
    }
    
    [Test]
    public void SuccessfulInitHero()
    {
        Hero hero = new Hero("Test", 15);

        Assert.That(hero.Name == "Test" && hero.Level == 15);
    }
    
    [Test]
    public void UnsuccessfulInitHero()
    {
        Assert.That(new Hero(null, 0).Name is null);
    }
    [Test]
    public void SuccessfulInitHeroRepository()
    {
        Hero hero = new Hero("Test", 15);
        HeroRepository heroRepository = new HeroRepository();
        //heroRepository.Create(hero);
        Assert.That(heroRepository.Heroes.Count == 0);
    }
    [Test]
    public void SuccessfulCreateHeroInRepository()
    {
        Hero hero = new Hero("Test", 15);
        HeroRepository heroRepository = new HeroRepository();
        //heroRepository.Create(hero);
        Assert.That(heroRepository.Create(hero) == $"Successfully added hero {hero.Name} with level {hero.Level}");
    }
    
    [Test]
    public void ThrowArgumentNullExceptionOnNullHeroCreation()
    {
        //Hero hero = new Hero("Test", 15);
        HeroRepository heroRepository = new HeroRepository();
        Assert.Throws<ArgumentNullException>(() => heroRepository.Create(null));
    }
    
    [Test]
    public void ThrowInvalidOperationExceptionOnDuplicateHeroCreation()
    {
        Hero hero = new Hero("Test", 15);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        Assert.Throws<InvalidOperationException>(() => heroRepository.Create(hero));
    }
    
    [Test]
    public void ValidHeroRemoval()
    {
        Hero hero = new Hero("Test", 15);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        Assert.That(heroRepository.Remove("Test"));
    }
    
    [Test]
    public void InvalidHeroRemoval()
    {
        Hero hero = new Hero("Test", 15);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        Assert.That(!(heroRepository.Remove("Penko")));
    }
    
    [Test]
    public void ArgumentNullExceptionOnNullNameForHeroRemoval()
    {
        Hero hero = new Hero("Test", 15);
        HeroRepository heroRepository = new HeroRepository();
        Assert.Throws<ArgumentNullException>(() => heroRepository.Remove(null));
    }
    
    [Test]
    public void SuccessfulGetHeroWithHighestLevel()
    {
        Hero hero = new Hero("Test", 15);
        Hero alphaHero = new Hero("Alpha", 30);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        heroRepository.Create(alphaHero);
        Assert
            .That(heroRepository
            .GetHeroWithHighestLevel()
            .Level == 30 
            && heroRepository
            .GetHeroWithHighestLevel()
            .Name == "Alpha");
    }
    
    [Test]
    public void UnSuccessfulGetHeroWithHighestLevel()
    {
        //Hero hero = new Hero("Test", 15);
        //Hero alphaHero = new Hero("Alpha", 30);
        HeroRepository heroRepository = new HeroRepository();

        Assert.Throws<IndexOutOfRangeException>(() => heroRepository.GetHeroWithHighestLevel());
    }
    [Test]
    public void SuccessfulGetHero()
    {
        Hero hero = new Hero("Test", 15);
        //Hero alphaHero = new Hero("Alpha", 30);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        Assert.That(heroRepository.GetHero("Test") == hero);
    }
    
    [Test]
    public void UnsuccessfulGetHero()
    {
        Hero hero = new Hero("Test", 15);
        //Hero alphaHero = new Hero("Alpha", 30);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        Assert.That(heroRepository.GetHero("Alpha") is null);
    }


}