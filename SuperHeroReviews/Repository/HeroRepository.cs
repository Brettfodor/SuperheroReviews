using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperHeroReviews.Models;
using SuperHeroReviews.Data;
using SuperHeroReviews.Repository;
using Microsoft.EntityFrameworkCore;

namespace SuperHeroReviews.Repository
{
    public class HeroRepository : IRepository<HeroModel>
    {
        private SuperContext db;
        public HeroRepository(SuperContext db)
        {
            this.db = db;
        }
        public int Count()
        {
            return db.Heroes.Count();
        }
        public void Create(HeroModel heroes)
        {
            db.Heroes.Add(heroes);
            db.SaveChanges();
        }
        public void Delete(HeroModel heroes)
        {
            db.Heroes.Remove(heroes);
            db.SaveChanges();
        }
        public void Edit(HeroModel heroes)
        {
            db.Heroes.Update(heroes);
            db.SaveChanges();
        }
        public IEnumerable<HeroModel> GetAll()
        {
            return db.Heroes.ToList();
        }
        public HeroModel GetByID(int id)
        {
            return db.Heroes.Single(p => p.ID == id);
        }
        //public IEnumerable<HeroModel> GetByHeroID(int id)
        //{
        //    yield return db.Heroes.Single(p => p.ID == id);
        //}
        public void Save()
        {
            db.SaveChanges();
        }
    }

    //public class HeroRepository : IRepository<HeroModel>
    //{
    //    public List<HeroModel> heroList;

    //    public HeroRepository()
    //    {
    //        heroList = new List<HeroModel>();

    //        heroList.Add(new HeroModel(1, "IronMan", "This character is awesome.", "Marvel", "Iron Man is an awesome Hero whose strength is derived from the powers of technology.  Using his enhanced iron suit, he is able to muster super strength, the ability to fly, laser cannons, rockets, and communications with his supercomputer Jarvis", "/images/IronMan.jpg"));

    //        heroList.Add(new HeroModel(2, "Thor", "This character is awesome.", "Marvel", "Thor is the God of Thunder, son of Odin father of all Gods in Norse Mythology.  He has an incredibly powerful hammer that only he has the ability to wield, and mastery over lighting.", "/images/thor.jpg"));

    //        heroList.Add(new HeroModel(3, "Spiderman", "This character is awesome.", "Marvel", "Peter Parker was an orphaned teenage boy who lived in Queens, New York with his Aunt May and Uncle Ben. He was a shy boy, but highly intelligent and excelled in science. He was often teased by other more popular kids like longtime nemesis Flash Thompson, but his life was soon to change on a visit to the science museum.At the science museum, Peter was bitten by a radioactive spider.The spider bite gave Peter spider - like powers with super strength and reflexes.He also had a “spider - sense” alerting him to danger.Armed with these new powers, Peter first sought fame and money before fighting crime.He worked with a wrestling circuit and got some fame and appeared on a television show.During a robbery of the television show, Peter has the chance to stop the thief but chose not to.Spider - Man has supplemented his powers with technology.Being a brilliant chemist and scientist, Peter has made web - slingers, bracelets that shoot out a sticky webbing, allowing him to swing from building to building and ensnare opponents.He has also developed stingers that shoot powerful energy blasts that can stun foes.", "/images/SpiderMan.jpg"));

    //        heroList.Add(new HeroModel(4, "Black Widow", "This character is awesome.", "Marvel", "Black widow is a super spy.", "/images/black-widow.jpg"));

    //        heroList.Add(new HeroModel(5, "Black Panther", "This character is awesome.", "Marvel", "Black panther is the king of Wakanda", "/images/BlackPanther.jpg"));

    //        heroList.Add(new HeroModel(6, "Wolverine", "This character is awesome.", "Marvel", "Wolverine is an invulnerable x-man that has razor sharp claws", "/images/wolverine.jpg"));

    //        heroList.Add(new HeroModel(7, "Thanos", "This character is awesome.", "Marvel", "Thanos is the most evil villain in the Marvel universe", "/images/Thanos.jpg"));

    //        heroList.Add(new HeroModel(8, "Antman", "This character is awesome.", "Marvel", "Ant-man has control over the powers of quantum mechanics", "/images/Ant-Man.jpg"));

    //        heroList.Add(new HeroModel(9, "Magneto", "This character is awesome.", "Marvel", "Magneto is ruler of all metal objects and the arch-nemesis of Charles Xavier", "/images/Magneto.jpg"));

    //        heroList.Add(new HeroModel(10, "Mystique", "This character is awesome.", "Marvel", "Mystique is a strange creature with blue skin who can take on the appearance of anyone she has seen", "/images/Mystique.jpg"));

    //        heroList.Add(new HeroModel(11, "Flash", "This character is awesome.", "DC", "The mysterious power known as the Speed Force is an energy field that has, over the centuries, granted incredible powers of velocity to certain heroes. The most famous of these is the Flash, also known as the Fastest Man Alive. Ever since the days of World War II, there has been a man clad in red who can run at impossible speeds, using his power to save lives and defend those who cannot defend themselves. All between the ticks of a second. In the 1940s, college student Jay Garrick acquired his super-speed abilities in a random lab accident and became the first DC Super Hero to go by the name the Flash. Years later, Jay was succeeded by police scientist Barry Allen, until Barry’s former kid partner Wally West took up the mantle at a time when Barry was considered dead. But, when Barry returned, he became the Flash once again. All three generations of speedsters have been cornerstone members of both the Justice Society and Justice League. The Flash has mastery over not just speed, but time itself, and he has often used his powers to travel though different eras and even into other dimensions. Although the Flash has not always been fast enough to outrun personal tragedy when it has come for him, he always does his best to prevent the same from happening to the people of Central City and Keystone City. In so doing, he's earned himself a spot among the greatest Super Heroes the DC Universe has ever known.", "/images/Flash.jpeg"));

    //        heroList.Add(new HeroModel(12, "Swamp Thing", "This character is awesome.", "DC", "Alec Holland was an idealistic scientist who was synthesizing a top-secret chemical in his hidden lab in the marshlands. But after a bomb in his office explodes, the young scientist is murdered. Or so it seems. Because rising in his place is the Swamp Thing, a creature made of vegetation that’s absorbed Alec Holland’s memories, personality—and grief. The monstrous Swamp Thing can control every iota of plant life on this planet, from the fungus on stale bread to forests of towering oaks. Superhumanly strong and grotesque, he can grow himself a full array of titanic bodies from even the tiniest sprout of green. A living embodiment of the power and terror in our environment, the Swamp Thing protects both humanity and the environment—usually from each other.", "/images/SwampThing.jpg"));

    //        heroList.Add(new HeroModel(13, "Aquaman", "This character is awesome.", "DC", "Monarch of the undersea realm of Atlantis and King of the Seven Seas, Aquaman is one of the most powerful DC Super Heroes—commanding a kingdom that covers three-quarters of the Earth’s surface, including all the creatures contained within. Arthur Curry came from humble beginnings, as most of his life was spent exiled from his home, unaware of his noble origins. When he finally took the throne as an adult, he became the most legendary king in Atlantean history. A founding member of the Justice League of America, Aquaman has fought alongside Superman, Batman and Wonder Woman and held his own against the biggest threats the universe has ever seen. Despite being misunderstood by many as someone who merely “talks to fish,” Aquaman’s super-strength and fighting prowess alone make him a force to be reckoned with. His telepathic abilities make him one of the most powerful minds on the planet. If one chooses to underestimate the sea king, they do so at their own peril.", "/images/AquaMan.jpg"));

    //        heroList.Add(new HeroModel(14, "Supergirl", "This character is awesome.", "DC", "Teenager Kara Zor-el was rocketed to Earth from the dying planet Krypton. Faced with an entire world completely unrecognizable from the one she grew up in, she’s the ultimate new girl in school—with a planet-splitting right hook. A lonely girl with astounding might, she struggles to find her identity on her new reluctant home. As the most powerful teenager on the planet, the Girl of Steel possesses all of Superman’s powers—from superhuman strength, speed, and invulnerability all the way down to his flight and enhanced senses. Still learning to control her awesome powers and lacking her cousin’s self-restraint, she may even be more dangerous than the Man of Steel. Disconnected from a world she’s still struggling to comprehend, she’ll find non-stop action and violence from her first minute on this planet.", "/images/supergirl.jpg"));

    //        heroList.Add(new HeroModel(15, "Wonder Woman", "This character is awesome.", "DC", "Wonder woman is a former amazon with super strength, and super intelligence", "/images/WonderWoman.jpg"));

    //        heroList.Add(new HeroModel(16, "Batman", "This character is awesome.", "DC", "One of the most iconic fictional characters in the world, Batman has dedicated his life to an endless crusade, a war on all criminals in the name of his murdered parents, who were taken from him when he was just a child. Since that tragic night, he has trained his body and mind to near physical perfection to be a self-made Super Hero. He's developed an arsenal of technology that would put most armies to shame. And he's assembled teams of his fellow DC Super Heroes, like the Justice League, the Outsiders and Batman, Incorporated. A playboy billionaire by day, Bruce Wayne’s double life affords him the comfort of a life without financial worry, a loyal butler-turned-guardian and the perfect base of operations in the ancient network of caves beneath his family’s sprawling estate. By night, however, he sheds all pretense, dons his iconic scalloped cape and pointed cowl and takes to the shadowy streets, skies and rooftops of Gotham City.", "/images/batman.jpg"));

    //        heroList.Add(new HeroModel(17, "Superman", "This character is awesome.", "DC", "Superman is the ultimate superhero whose only weakness is Kryptonite, fractional piece of his destroyed home planet", "/images/superman.jpg"));

    //        heroList.Add(new HeroModel(18, "Beast Boy", "This character is awesome.", "DC", "It’s not easy being green, but Garfield “Gar” Logan certainly makes the best of it. After contracting a rare disease as a child, Gar’s parents were forced to administer an experimental genetic treatment involving the DNA of animals with known resistances to the disease as a potential cure. The good news: their experiment worked. The bad news: it had some pretty dramatic side effects. It turned Gar’s skin, hair and eyes a bright green color and gave him the incredible ability to shapeshift into any animal at will…with just one important caveat. Any form Gar happens to take will also be completely green, no matter what. So much for being able to blend in. Luckily, fading into the background has never been Gar’s goal in life. When he’s not using his powers to be a superhero, he spends his time as an amateur actor and social butterfly, winning friends and “adoring fans” (at least, in his head) wherever he goes. He’s quick with a joke and quicker with a smile, and remains upbeat, optimistic and flirtatious even through the worst of times, making him a valuable asset for the morale of any team he might find himself a part of.", "/images/Beast-Boy.jpg"));

    //        heroList.Add(new HeroModel(19, "Cyborg", "This character is awesome.","DC", "Although he always exhibited a genius level intellect, young Victor Stone didn’t want a life dedicated to science and research like his parents. Instead, Vic dreamed of being a football player, and devoted all of his time to becoming a star athlete while he was still in high school. But a tragic twist of fate that should have left him dead instead found him becoming part man and part machine—a Cyborg. Saved by his scientist father after an accident left very little of Victor’s body intact, Dr. Silas Stone used all of his advanced scientific knowledge to save his only child’s life, and to rebuild him into a superior being, one that was arguably now more machine than man. As a cyborg, Vic was now far stronger than the average person,  could interface with computers, and emit various types of energy that made him a formidable fighter. Although he ultimately chose the path of the superhero, Victor never fully acclimated to being only partially human. He always carried a sadness within him as he mourns for the normal life he never had. One of the planet’s greatest heroes, Cyborg nevertheless puts all of his internal struggles aside when the time comes to save innocent lives and protect the Earth. Because of his ability to interface with computer systems, perhaps there is no hero more fitting for this modern, digital age.", "/images/VictorStone.jpg"));

    //        heroList.Add(new HeroModel(20, "Nightwing", "This character is awesome.", "DC", "When his circus acrobat family was brutally murdered, Dick Grayson was taken in by billionaire and bat-friendly super hero Bruce Wayne. Bruce shared his secret life as Batman with the young boy and eventually molded him into Robin—the Dark Knight’s partner in Gotham. But as Dick grew older, playing second fiddle to the sternest hero in the Justice League began to wear on him, and eventually he struck out on his own, staying true to what he learned as Robin while coming into his own as a respected member of the super hero pantheon. His code, like his mentor’s, is simple—if you’re breaking the law on his turf, watch out. Anyone who doesn’t can expect a short and most assuredly painful trip to Arkham. Yet, while he may share methods and motivation with Batman, Dick knows what being Batman can do. He doesn’t want to become as dark, controlling and lonely as Bruce. But for all the good he’s accomplished while avoiding it, one question is unavoidable—without going as far as Batman, can Nightwing be as effective as he ultimately wants to be?", "/images/NightWing.jpg"));

    //        heroList.Add(new HeroModel(21, "Joker", "This character is awesome.", "DC", "Whether by way of award-winning films like ‘The Dark Knight,’ Emmy-winning animated programs like ‘Batman: The Animated Series,' video game appearances such as the record - breaking ‘Batman: Arkham Asylum,’ or the countless comics stacking comic book shelves and digital libraries, the Joker stands unquestionably as the most recognizable and popular comic book villain in pop culture history.Unpredictable, violent and incredibly dangerous, he is chaos personified and has taken on everyone from his archenemy Batman to even the Man of Steel.But Gotham remains his primary home and Batman his biggest adversary, and no hero is perhaps better suited as in many ways, the Joker is the polar opposite of the Dark Knight.Both were created by a great tragedy, but Batman has since vowed to do whatever it takes to prevent similar incidents, the Joker revels in creating chaos and destroying lives, believing that life’s a big joke and psychotically demonstrating that in a moment, it can all change.Not much is known about his past, but his acts during the present are what define the Joker as one of the greatest threats to our heroes and the people they've sworn to protect. He's killed a Robin, crippled Batgirl, and tortured and murdered countless people throughout the DC Universe—all just for a laugh.", "/images/joker.jpg"));
    //    }

    //    public IEnumerable<HeroModel> GetAll()
    //    {
    //        return heroList;
    //    }

    //    public HeroModel GetById(int id)
    //    {
    //        return heroList.Single(c => c.ID == id);

    //    }


    //    public List<HeroModel> GetByUniverse(string universe)
    //    {
    //        return heroList.FindAll(c => c.Universe == universe);

    //    }


    //}
}
