using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneysReborn.NPCs
{
    public class TownNPCNames : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public override void ModifyNPCNameList(NPC npc, List<string> nameList)
        {
            if(npc.type == NPCID.Angler) {
                nameList.Add("Timmy");
                nameList.Add("Willy");
				nameList.Add("Gregory");
				nameList.Add("Oswald");
				nameList.Add("Vincent");
				nameList.Add("Leo"); 
				nameList.Add("Huck");
            };
			//if(npc.type == NPCID.Archer) {
                //nameList.Add("Lara");
                //nameList.Add("Aloy");
				//nameList.Add("Katniss");
                //nameList.Add("Sylvanas");
            //};
			if(npc.type == NPCID.ArmsDealer) {
                nameList.Add("Wrex");
				nameList.Add("Kirrahe");
				nameList.Add("Kaidan");
				nameList.Add("James");
				nameList.Add("Sam");
				nameList.Add("Victus");
				nameList.Add("Cole");
				nameList.Add("Cassidy");
				nameList.Add("Marcus");
				nameList.Add("Jesse");
				nameList.Add("McCree");
				nameList.Add("Frank");
				nameList.Add("Arthur");
				nameList.Add("Phil");
            };
			if(npc.type == NPCID.BestiaryGirl) {
                nameList.Add("Jack");
				nameList.Add("Nyreen");
				nameList.Add("Ashley");
				nameList.Add("Roxanne"); 
				nameList.Add("Enid");
            };
			if(npc.type == NPCID.Clothier) {
                nameList.Add("Shanel");
                nameList.Add("Guccio");
				nameList.Add("Elliot");
            };
			if(npc.type == NPCID.Cyborg) {
                nameList.Add("Shepard");
				nameList.Add("Legion");
				nameList.Add("Geth");
				nameList.Add("Edi");
				nameList.Add("Saren");
				nameList.Add("T-800");
				nameList.Add("Ennard");
				nameList.Add("Ra1d3n");
            };
			if(npc.type == NPCID.DD2Bartender) {
				nameList.Add("Gas"); 
				nameList.Add("Olaf");
				nameList.Add("Griffarin");
                nameList.Add("Dalum");
                nameList.Add("Olivier");
                nameList.Add("Stjepan");
                nameList.Add("Jonas");				    		
            };
			if(npc.type == NPCID.Demolitionist) {
                nameList.Add("Zaeed");
				nameList.Add("Grunt");
				nameList.Add("Sam");
				nameList.Add("Junkrat");
				nameList.Add("Phil");
            };
			if(npc.type == NPCID.Dryad) {
				nameList.Add("Samara");
				nameList.Add("Sha’ira");
				nameList.Add("Benezia");
				nameList.Add("Ysera");
            };
			if(npc.type == NPCID.DyeTrader) {
                nameList.Add("Jamal");
				nameList.Add("Karim");
				nameList.Add("Omar");
				nameList.Add("Saif");
            };
			if(npc.type == NPCID.GoblinTinkerer) {
                nameList.Add("Pin");
				nameList.Add("Garrus");
				nameList.Add("Norman");
				nameList.Add("Demetriusor");
				nameList.Add("Henrik");
				nameList.Add("Williamort");
            };
			if(npc.type == NPCID.Golfer) {
                nameList.Add("Rory McEagle");
				nameList.Add("James Blade");
				nameList.Add("Hale Iron"); 
				nameList.Add("Davis Glove III"); 
				nameList.Add("Phil Mythrilson");
				nameList.Add("Lee Vinevino");
				nameList.Add("Payne Slimewart");
				nameList.Add("Inbee Shark");
				nameList.Add("Webb Silverson");
            };
			if(npc.type == NPCID.Guide) {
                nameList.Add("Aaron");
                nameList.Add("Joseph");
				nameList.Add("Kendrick");
				nameList.Add("Link");
                nameList.Add("Lucas");
                nameList.Add("Marlon");
                nameList.Add("Oscar");
                nameList.Add("Robert");
				nameList.Add("Roman");
				nameList.Add("Richard");
				nameList.Add("Sebastian");
				nameList.Add("Trevor");
            }; 
			if(npc.type == NPCID.Mechanic) {
                nameList.Add("Tali");
				nameList.Add("Maru");
				nameList.Add("Cindy");
				nameList.Add("Hana");
				nameList.Add("Moze");
				nameList.Add("Ellie");
            };
            if(npc.type == NPCID.Merchant) {
                nameList.Add("Dave");
				nameList.Add("Morshu");
				nameList.Add("Marcus");
				nameList.Add("Harrot");
				nameList.Add("Ledra");
				nameList.Add("Marab");
				nameList.Add("Morlan");
				nameList.Add("Opold");
				nameList.Add("Ratch");
				nameList.Add("Rentola");
				nameList.Add("Pierre"); 
				nameList.Add("Morris"); 
            };
            if(npc.type == NPCID.Nurse) {
                nameList.Add("Liara");
				nameList.Add("Karin");
				nameList.Add("Chloe");
				nameList.Add("Harley");
				nameList.Add("Poppy");
				nameList.Add("Eliza");
				nameList.Add("Maru");
				nameList.Add("Florence");
				nameList.Add("Lavern");
				nameList.Add("Carla");
				nameList.Add("Mercy");
				nameList.Add("Ana");
            };
            if(npc.type == NPCID.Painter) {
                nameList.Add("Victor");
				nameList.Add("Vincent");
                nameList.Add("Paul");	
                nameList.Add("Pablo");		
                nameList.Add("Gustav");
                nameList.Add("Salvador"); 	
                nameList.Add("Peter");
                nameList.Add("Carl");				
            };
			if(npc.type == NPCID.PartyGirl) {
                nameList.Add("Samantha");
				nameList.Add("Kelly");
				nameList.Add("Pinkamena");
				nameList.Add("Teto");
				nameList.Add("Sayori");
            };
			if(npc.type == NPCID.Pirate) {
                nameList.Add("Flint");
				nameList.Add("Ahab");
				nameList.Add("John Silver");
				nameList.Add("John Tungsten");
				nameList.Add("Billy Bones");
				nameList.Add("Davy Jones");
            };
			if(npc.type == NPCID.Princess) {
                nameList.Add("Diana");
                nameList.Add("Fiona");
				nameList.Add("Anastasia");
                nameList.Add("Aurora");		 		
                nameList.Add("Anne");
                nameList.Add("Victoria");
				nameList.Add("Sparkle");
				nameList.Add("Isabella");
				nameList.Add("Felicia");
				nameList.Add("Rebecca");
				nameList.Add("Jas");
            };
			if(npc.type == NPCID.SkeletonMerchant) {
                nameList.Add("Sans");
				nameList.Add("Marrowlyn Manson");
				nameList.Add("Femur Mercury");
				nameList.Add("Davy Bones");
				nameList.Add("Skelton John");
				nameList.Add("Harrison Femur");
				nameList.Add("Morgan Freebone");
                nameList.Add("Clint Bonewood");	   
            };
			if(npc.type == NPCID.Steampunker) {
                nameList.Add("Miranda");
				nameList.Add("Kasumi");
				nameList.Add("Elizabeth");
				nameList.Add("Jinx");
            };
            if(npc.type == NPCID.Stylist) {
                nameList.Add("Dolores");
                nameList.Add("Karla");
                nameList.Add("Elizabeth");
                nameList.Add("Rebecca");
				nameList.Add("Barbara");
                nameList.Add("Ilaria");
                nameList.Add("Jessica");
                nameList.Add("Sally");
				nameList.Add("Haley");
            };
			if(npc.type == NPCID.TaxCollector) {
                nameList.Add("Donald");
                nameList.Add("Gerald");
				nameList.Add("Avery");
				nameList.Add("Charles");
                nameList.Add("Glomgold");
                nameList.Add("Flintheart");
                nameList.Add("Lawrence");
                nameList.Add("Harold");
				nameList.Add("Donnel");
				nameList.Add("David");
				nameList.Add("Barla");
				nameList.Add("Lewis");
            };
			if(npc.type == NPCID.TownBunny) {

            };
            if(npc.type == NPCID.TownCat) {
                nameList.Add("Philemon");      
                nameList.Add("Kuzya");
			    nameList.Add("Semen");
            };
            if(npc.type == NPCID.TownDog) {

            };
            if(npc.type == NPCID.TravellingMerchant) {
                nameList.Add("Kenn");
				nameList.Add("Emeraldo");
            };			
			if(npc.type == NPCID.Truffle) {
                nameList.Add("Boletus");
				nameList.Add("Niscalo");
				nameList.Add("Truffleton");
				nameList.Add("Toadston");
				nameList.Add("Mushbert");
				nameList.Add("Shroomington");
            };
            if(npc.type == NPCID.WitchDoctor) {
                nameList.Add("Thane");
				nameList.Add("Javik");
				nameList.Add("Mordin");
				nameList.Add("Padok");
				nameList.Add("Vol'jin");
            };
            if(npc.type == NPCID.Wizard) {
                nameList.Add("Gandalf");
                nameList.Add("Dumbledore");	
                nameList.Add("Rasmodius");							
            }; 
        }

    }
}