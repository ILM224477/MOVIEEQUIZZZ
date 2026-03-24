using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MOVIEEQUIZZZ
{
    // Represents one user entry stored in hereglechiin burtgel.json
    public class UserEntry
    {
        public string Register { get; set; } = "";
        public string Firstname { get; set; } = "";
        public string Lastname { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Birthdate { get; set; } = "";
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public int ScoreMovie { get; set; } = 0;
        public int ScoreAnime { get; set; } = 0;
        public int ScoreCartoon { get; set; } = 0;
        public int ScoreJapanese { get; set; } = 0;
        public int ScoreKorean { get; set; } = 0;
        public int ScoreSpanish { get; set; } = 0;
    }

    public static class UserManager
    {
        // The logged-in user's Username
        public static string CurrentUser { get; set; } = "";

        private static string FilePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hereglechiin burtgel.json");

        // Load all users from JSON
        public static List<UserEntry> LoadAll()
        {
            var list = new List<UserEntry>();
            if (!File.Exists(FilePath))
                return list;

            string json = File.ReadAllText(FilePath, Encoding.UTF8).Trim();
            if (string.IsNullOrWhiteSpace(json) || json == "[]")
                return list;

            // Parse simple JSON array manually (no external library needed)
            json = json.Trim();
            if (json.StartsWith("[")) json = json.Substring(1);
            if (json.EndsWith("]")) json = json.Substring(0, json.Length - 1);

            // Split objects by "},{"
            var objects = SplitObjects(json);
            foreach (var obj in objects)
            {
                var entry = ParseEntry(obj);
                if (entry != null) list.Add(entry);
            }
            return list;
        }

        // Save all users to JSON
        public static void SaveAll(List<UserEntry> users)
        {
            var sb = new StringBuilder();
            sb.AppendLine("[");
            for (int i = 0; i < users.Count; i++)
            {
                sb.Append(Serialize(users[i]));
                if (i < users.Count - 1) sb.AppendLine(",");
                else sb.AppendLine();
            }
            sb.AppendLine("]");
            File.WriteAllText(FilePath, sb.ToString(), Encoding.UTF8);
        }

        // Register a new user. Returns false if username already exists.
        public static bool Register(UserEntry newUser)
        {
            var users = LoadAll();
            foreach (var u in users)
            {
                if (u.Username.Equals(newUser.Username, StringComparison.OrdinalIgnoreCase))
                    return false;
            }
            users.Add(newUser);
            SaveAll(users);
            return true;
        }

        // Validate login. Returns the UserEntry or null on failure.
        public static UserEntry Validate(string username, string password)
        {
            var users = LoadAll();
            foreach (var u in users)
            {
                if (u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
                    && u.Password == password)
                    return u;
            }
            return null;
        }

        // Save (or update) the best score for a category.
        public static void SaveScore(string username, string category, int score)
        {
            if (string.IsNullOrEmpty(username)) return;
            var users = LoadAll();
            foreach (var u in users)
            {
                if (u.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    switch (category)
                    {
                        case "Movie":    if (score > u.ScoreMovie)    u.ScoreMovie    = score; break;
                        case "Anime":    if (score > u.ScoreAnime)    u.ScoreAnime    = score; break;
                        case "Cartoon":  if (score > u.ScoreCartoon)  u.ScoreCartoon  = score; break;
                        case "Japanese": if (score > u.ScoreJapanese) u.ScoreJapanese = score; break;
                        case "Korean":   if (score > u.ScoreKorean)   u.ScoreKorean   = score; break;
                        case "Spanish":  if (score > u.ScoreSpanish)  u.ScoreSpanish  = score; break;
                    }
                    break;
                }
            }
            SaveAll(users);
        }

        // ---- Minimal JSON helpers ----

        private static string Escape(string s) =>
            s?.Replace("\\", "\\\\").Replace("\"", "\\\"") ?? "";

        private static string Serialize(UserEntry u)
        {
            return $"  {{\"Register\":\"{Escape(u.Register)}\",\"Firstname\":\"{Escape(u.Firstname)}\",\"Lastname\":\"{Escape(u.Lastname)}\",\"Gender\":\"{Escape(u.Gender)}\",\"Birthdate\":\"{Escape(u.Birthdate)}\",\"Username\":\"{Escape(u.Username)}\",\"Password\":\"{Escape(u.Password)}\",\"ScoreMovie\":{u.ScoreMovie},\"ScoreAnime\":{u.ScoreAnime},\"ScoreCartoon\":{u.ScoreCartoon},\"ScoreJapanese\":{u.ScoreJapanese},\"ScoreKorean\":{u.ScoreKorean},\"ScoreSpanish\":{u.ScoreSpanish}}}";
        }

        private static List<string> SplitObjects(string json)
        {
            var result = new List<string>();
            int depth = 0;
            int start = -1;
            for (int i = 0; i < json.Length; i++)
            {
                char c = json[i];
                if (c == '{') { depth++; if (depth == 1) start = i; }
                else if (c == '}') { depth--; if (depth == 0 && start >= 0) { result.Add(json.Substring(start, i - start + 1)); start = -1; } }
            }
            return result;
        }

        private static UserEntry ParseEntry(string obj)
        {
            try
            {
                var e = new UserEntry();
                e.Register   = GetStr(obj, "Register");
                e.Firstname  = GetStr(obj, "Firstname");
                e.Lastname   = GetStr(obj, "Lastname");
                e.Gender     = GetStr(obj, "Gender");
                e.Birthdate  = GetStr(obj, "Birthdate");
                e.Username   = GetStr(obj, "Username");
                e.Password   = GetStr(obj, "Password");
                e.ScoreMovie    = GetInt(obj, "ScoreMovie");
                e.ScoreAnime    = GetInt(obj, "ScoreAnime");
                e.ScoreCartoon  = GetInt(obj, "ScoreCartoon");
                e.ScoreJapanese = GetInt(obj, "ScoreJapanese");
                e.ScoreKorean   = GetInt(obj, "ScoreKorean");
                e.ScoreSpanish  = GetInt(obj, "ScoreSpanish");
                return e;
            }
            catch { return null; }
        }

        private static string GetStr(string json, string key)
        {
            string search = $"\"{key}\":\"";
            int idx = json.IndexOf(search);
            if (idx < 0) return "";
            idx += search.Length;
            int end = json.IndexOf('"', idx);
            if (end < 0) return "";
            return json.Substring(idx, end - idx).Replace("\\\"", "\"").Replace("\\\\", "\\");
        }

        private static int GetInt(string json, string key)
        {
            string search = $"\"{key}\":";
            int idx = json.IndexOf(search);
            if (idx < 0) return 0;
            idx += search.Length;
            int end = idx;
            while (end < json.Length && (char.IsDigit(json[end]) || json[end] == '-')) end++;
            return int.TryParse(json.Substring(idx, end - idx), out int val) ? val : 0;
        }
    }
}
