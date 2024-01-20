namespace PartyInvites.Models
{
    public static class Repository{
        //Esta manera de instanciar tambien es legal pero esta un poco rara
            private static List<GuestResponse> responses = new();
            public static IEnumerable<GuestResponse> Responses => responses;
            public static void AddResponse(GuestResponse response) {
            Console.WriteLine(response);
            responses.Add(response);
        }
    }
}