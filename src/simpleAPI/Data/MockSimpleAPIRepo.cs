// using System.collections.Generic;
// using SimpleAPI.Models;

// namespace SimpleAPI.Data 
// {
//     public class MockSimpleAPIRepo : ISimpleAPIRepo
//     {
//         public IEnumerable<SimpleAPI> GetAppSImpleAPI()
//         {
//             var simpleAPI = new List<simpleAPI>
//             {
//             //throw new System,NotImplementedException();
            
//                 new simpleAPI{Id=0, HowTo="Boil an egg", Line="Put water in the pan", Platform="kettle and egg"},
//                 new simpleAPI{Id=1, HowTo="fry an egg", Line="Put the pan on fire ", Platform="pan and egg"},
//                 new simplePI{Id=2, HowTo="Make a cup of tea", Line="Put water in the cup", Platform="cup and spoon"}
             
//             };
//             return simpleAPI;
//         }
        
//         public SimpleAPI GetSimpleAPIById(int id)
//         {
//             //throw new System.NotImplementedException();
//             return new SimpleAPI{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="kettle and egg"};
//         }
//     }
// }