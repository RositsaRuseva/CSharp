// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    //using FestivalManager.Entities;
    using NUnit.Framework;
    using System;

    [TestFixture]
	public class StageTests
    {
		private Stage stage;
		private Performer performerIsNull;
		private Performer performerIsUnder18;
		private Performer performerIsValid;
		private Song songIsNull;
		private Song songUnder1Min;
		private Song songIsValid;

		[SetUp]
		public void SetUp()
        {
			this.stage = new Stage();
			this.performerIsNull = null;
			this.performerIsUnder18 = new Performer("Test", "Performer", 17);
			this.performerIsValid = new Performer("Test", "Performer", 22);
			this.songIsNull = null;
			this.songUnder1Min = new Song("TestSong", TimeSpan.FromSeconds(30));
			this.songIsValid = new Song("TestSong", TimeSpan.FromSeconds(200));
        }
		[Test]
	    public void StageIsNotNull()
	    {
			Assert.IsNotNull(stage);
		}
		[Test]
		public void PerformersIsNotNull()
        {
			Assert.IsNotNull(stage.Performers);
        }
		[Test]
		public void AddPerformerPerformerIsNull()
        {
			Assert.That(() => stage.AddPerformer(performerIsNull), Throws.ArgumentNullException);
        }
		[Test]
		public void AddPerformerPerformerAgeUnder18()
        {
			Assert.That(() => stage.AddPerformer(performerIsUnder18), Throws.ArgumentException);
        }
		[Test]
		public void AddPerformerPerformerIsValid()
        {
			stage.AddPerformer(performerIsValid);
			Assert.AreEqual(1, stage.Performers.Count);
        }
		[Test]
		public void AddSongSongIsNull()
        {
			Assert.That(() => stage.AddSong(songIsNull), Throws.ArgumentNullException);
        }
		[Test]
		public void AddSongSongUnder1Min()
        {
			Assert.That(() => stage.AddSong(songUnder1Min), Throws.ArgumentException);
        }
		[Test]
		public void AddSongToPerformerSongIsValidPerformerIsNull()
        {
			Assert.That(() => stage.AddSongToPerformer(songIsValid.Name, null), Throws.ArgumentNullException);
        }
		[Test]
		public void AddSongToPerformerPerformerIsValidSongIsNull()
        {
			Assert.That(() => stage.AddSongToPerformer(null, performerIsValid.FullName), Throws.ArgumentNullException);
        }
		[Test]
		public void AddSongToPerformerPerformerAndSongAreValid()
        {
			stage.AddPerformer(performerIsValid);
			stage.AddSong(songIsValid);

			Assert.AreEqual($"{songIsValid} will be performed by {performerIsValid.FullName}", stage.AddSongToPerformer(songIsValid.Name, performerIsValid.FullName));
        }
		[Test]
		public void PlayMethodReturnsString()
        {
			stage.AddPerformer(performerIsValid);
			stage.AddSong(songIsValid);
			stage.AddSongToPerformer(songIsValid.Name, performerIsValid.FullName);
			Assert.AreEqual($"1 performers played 1 songs", stage.Play());
        }

	}
}
