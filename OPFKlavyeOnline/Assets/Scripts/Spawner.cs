using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameManager gameManager;
    public Text inputText;
    public Transform spawnPos;
    public GameObject spawnee;
    public GameObject starPref;
    private int count = 1;
    public TextMeshProUGUI stepCountText;
    public TextMeshProUGUI skorText;
    public InputField if1;
    public TextMeshPro wordText;
    public TextMeshPro wordTextUI;
    private string currentWord = "";
    private int skor = 0;
    private string[] words;
    public static string username;
    public HighscoreTable hst;
    public HighscoreTableMain hstm;
    public static int totalSkor = 0;
    private bool isFinish = false;
    public AudioSource keyPressSound;
    public AudioSource trueWordSound;
    public AudioSource wrongKeySound;
    public AudioSource levelCompleteSound;
    public AudioSource capslockOnSound;
    public AudioSource spPopSound;
    private float y = 0;
    private float z = 0;
    public TMP_InputField oldWordsList;
    public Scrollbar scb;
    private bool isWrong = false;
    private bool isChange = false;
    public GameObject initialSkorText;
    public Animator animator;
    public TextMeshProUGUI sbText;
    public GameObject speechBaloon;
    public GameObject leftHand;
    public GameObject rightHand;
    public Button handsOnButton;
    private bool isHandsActive = false;
    public Button thumbsOnButton;
    public GameObject leftThumb;
    public GameObject rightThumb;
    private GameObject[] steps = new GameObject[11];
    private Color[] myColors;
    private float animatorY = 2;
    bool includeSpace = false;
    

  //  [System.Runtime.InteropServices.DllImport("USER32.dll")] public static extern short GetKeyState(int nVirtKey);
   // bool IsCapsLockOn => (GetKeyState(0x14) & 1) > 0;



    private void Start()
    {
        spawnee.GetComponent<Renderer>().enabled = true;
        switch (SceneManager.GetActiveScene().name)
        {
            case "Level1":
                words = new string[] { "a a a", "a a a", "k k k", "k k k", "a a a", "k k k", "aka", "aka", "aka", "aka", "aka", "kak", "kak", "kak", "kak", "aka", "e e e", "e e e", "m m m", "m m m", "e e e", "m m m", "eme", "eme", "i i i", "i i i", "l l l", "l l l", "ili", "ili", "kil", "kil", "u u u", "u u u", "y y y", "y y y", "u u u", "y y y", "uyu", "uyu", "kak", "kak", "kak", "kem", "kem", "kem", "kek", "kek", "kil", "kil", "kil", "ilk", "ilk", "ilik", "yum", "yum", "aka", "aka", "aka", "eme", "eme", "eme", "ili", "ili", "uyu", "uyu", "uyu", "kim", "kim", "kim", "mek", "mek", "ulu", "ulu", "ulu", "ulu", "yuk", "yak", "yak", "yay", "ala", "ala", "ala", "ala", "aya", "aya", "aya", "aya", "mim", "mim", "mek", "mek", "kil", "kek", "kak", "yum" }; myColors = new Color[] {
        new Color(255/255f,0/255f,0/255f),
        new Color(255 / 255f, 255 / 255f, 0 / 255f),
        new Color(0 / 255f, 0 / 255f, 255 / 255f),
        new Color(0 / 255f, 204 / 255f, 0 / 255f),
        new Color(102 / 255f, 0 / 255f, 204 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Cat");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("1");
                break;
            case "Level2":
                words = new string[] { "aka", "aka", "eke", "keke", "iki", "kiki", "kum", "kumu", "kay", "kay", "em", "me", "al", "ala", "aya", "aya", "yek", "yek", "um", "uma", "mum", "muma", "mumu", "yum", "uyu", "kim", "kil", "iyi", "t t t", "ktk", "ktk", "tkt", "kat", "kat", "tak", "tak", "yat", "tat", "kit", "tik", "kit", "kut", "kutu", "alt", "alt", "tek", "tek", "ata", "ata", "mit", "mit", "mut", "mut", "mat", "mata", "yat", "yat", "tel", "tel", "tut", "tuttu", "tul", "tula", "yit", "yit", "yat", "yat", "yet", "yet", "kit", "kit", "tel", "tel", "tem", "tem", "tek", "tek", "ak", "takt", "tut", "tut", "tat", "tat", "kat", "kat", "kata", "kata", "tel", "tel", "tele", "tele", "tama", "mete", "etem", "teke", "kutu", "tuttu", "tula", "tamam", "mete", "tam", "kutu", "et", "tuttu", "mete", "tam", "kutu", "tut" };
                myColors = new Color[] {
        new Color(255/255f,0/255f,0/255f),
        new Color(255 / 255f, 255 / 255f, 0 / 255f),
        new Color(0 / 255f, 0 / 255f, 255 / 255f),
        new Color(0 / 255f, 204 / 255f, 0 / 255f),
        new Color(102 / 255f, 0 / 255f, 204 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Cat");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("1");
                break;
            case "Level3":
                words = new string[] { "kak", "kak", "kem", "kem", "kil", "kil", "uyu", "uyu", "ulu", "ulu", "kat", "kat", "mat", "mat", "tik", "tik", "yut", "yut", "yet", "yet", "ata", "ata", "kul", "kul", "kel", "kel", "kal", "kala", "yel", "yele", "ü ü ü", "ü ü ü", "aüa", "aüa", "akü", "akü", "ekü", "ekü", "küt", "küt", "kül", "kül", "üye", "üye", "ütü", "ütü", "tüy", "tüy", "tül", "tül", "yük", "yük", "tüm", "tüm", "tüt", "tüt", "ümü", "ümü", "küm", "küm", "ekü", "ekü", "eküm", "eküm", "tüm", "tüm", "tüme", "tüme", "akü", "yük", "yük", "yüke", "yüke", "ütü", "ütü", "ütüm", "ütüm", "kül", "küm", "küm", "küme", "küme", "ülk", "ülk", "ülke", "ülke", "ülkem", "ülkem", "tül", "tül", "tülü", "tüyü", "lüle", "lülem", "yüke", "yüke", "üyem", "üyem", "mülk", "akü", "akü", "aküm", "aküm", "aküme", "akümü" }; myColors = new Color[] {
        new Color(255/255f,0/255f,0/255f),
        new Color(255 / 255f, 255 / 255f, 0 / 255f),
        new Color(0 / 255f, 0 / 255f, 255 / 255f),
        new Color(0 / 255f, 204 / 255f, 0 / 255f),
        new Color(102 / 255f, 0 / 255f, 204 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Cat");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("1");
                break;
            case "Level4":
                words = new string[] { "ulu", "ulu", "iyi", "iyi", "ele", "ele", "ata", "ata", "akü", "akü", "kul", "kul", "kut", "kut", "ilk", "ilk", "kel", "kel", "ütü", "ütü", "yak", "yak", "yek", "yek", "yem", "yem", "yat", "yat", "yut", "yut", "ş ş ş", "yşy", "yşy", "yşy", "yaş", "yaş", "şey", "şey", "şam", "şam", "şak", "şak", "kaş", "kaş", "tuş", "tuş", "muş", "muş", "kuş", "kuş", "taş", "taş", "küş", "küş", "şeş", "şeş", "şut", "şut", "aşa", "aşa", "şey", "şey", "şeyi", "şeyi", "şiş", "şiş", "şişi", "şişe", "taş", "işi", "işi", "işim", "işim", "tuş", "tuş", "tuşa", "tuşa", "yaş", "şak", "şak", "şaka", "şaka", "taş", "taş", "taşa", "taşa", "şut", "şaş", "şaşa", "şal", "şala", "yaşa", "yaşam", "yaşat", "maşa", "maaş", "şiş", "şişe", "şeyi", "şeyi", "işim", "işim", "işimi", "ekşi", "ekşit" }; myColors = new Color[] {
        new Color(230 / 255f, 1 / 255f, 15 / 255f),
        new Color(126 / 255f, 184 / 255f, 255 / 255f),
        new Color(254 / 255f, 218 / 255f, 0 / 255f),
        new Color(191 / 255f, 129 / 255f, 231 / 255f),
        new Color(75 / 255f, 195 / 255f, 238 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Dog");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("2");
                break;
            case "Level5":
                words = new string[] { "aka", "tak", "tek", "tik", "mil", "mul", "taş", "yaş", "kaş", "akü", "akü", "tak", "tak", "yem", "yem", "kum", "kut", "tut", "şu", "şu", "kuş", "kuşa", "kuşa", "iki", "iki", "elma", "elma", "şu", "kuşa", "yem", "at", "ali", "şu", "kuşa", "yem", "at", "ı ı ı", "ı ı ı", "ı ı ı", "aıa", "aıa", "aıa", "ata", "akı", "akı", "alı", "atı", "atı", "aşı", "aşı", "ayı", "ayı", "yık", "yık", "yıka", "aşı", "aşı", "ayı", "ayık", "kış", "mış", "şık", "şıkmış", "akış", "kıy", "kıy", "kış", "kış", "yıl", "yıl", "tık", "tık", "tıka", "ılık", "ılık", "et", "ye", "ile", "ışık", "eti", "ılık", "ılık", "ilik", "ilik", "ayık", "ayık", "yakı", "yakıt", "yakıt", "yakı", "yak", "ışık", "ışıl", "ışıl", "akıt", "aşım", "aşıma", "ışık", "taşı", "almış", "ışık", "taşı", "atmış", "ışık", "ay", "ışımış", "ışık", "kuş", "almış" }; myColors = new Color[] {
        new Color(230 / 255f, 1 / 255f, 15 / 255f),
        new Color(126 / 255f, 184 / 255f, 255 / 255f),
        new Color(254 / 255f, 218 / 255f, 0 / 255f),
        new Color(191 / 255f, 129 / 255f, 231 / 255f),
        new Color(75 / 255f, 195 / 255f, 238 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Dog");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("2");
                break;
            case "Level6":
                words = new string[] { "aya", "aya", "ala", "ala", "aka", "aka", "ata", "ata", "kem", "kem", "ele", "ele", "eke", "eke", "ete", "ete", "iyi", "iyi", "ili", "ili", "iki", "iki", "iki", "uyu", "uyu", "ulu", "ulu", "yaş", "yaş", "akü", "akü", "K K K", "Ku", "Ku", "Kum", "Kum", "Mu", "Mum", "Mum", "Yum", "Yum", "Tut", "Tut", "Mut", "Mut", "Yut", "Yut", "Yaş", "Şaş", "Tül", "Kuş", "akü", "akü", "tak", "tak", "kem", "kem", "kil", "kil", "kul", "kul", "uyu", "uyu", "yaş", "yaş", "şak", "şak", "kuş", "kuş", "muş", "muş", "ele", "eke", "iki", "ili", "tüm", "tül", "eti", "üye", "kaş", "şaş", "A A A", "Ay", "Ay", "Aya", "Aya", "İy", "İy", "İyi", "İyi", "Uyu", "Uyu", "Üye", "Üye", "Eke", "Eke", "İki", "İki", "Ata", "Ata", "akı", "alı", "atı", "aşı", "I I I", "Ilı", "Ilık", "Işı" }; myColors = new Color[] {
        new Color(230 / 255f, 1 / 255f, 15 / 255f),
        new Color(126 / 255f, 184 / 255f, 255 / 255f),
        new Color(254 / 255f, 218 / 255f, 0 / 255f),
        new Color(191 / 255f, 129 / 255f, 231 / 255f),
        new Color(75 / 255f, 195 / 255f, 238 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Dog");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("2");
                break;
            case "Level7":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "alı", "alı", "ayı", "ayı", "şık", "şık", "kaya", "kaya", "at", "ata", "kaşık", "Işıl", "şakayla", "tüm", "iki", "kutu", "elmayı", "yemiş", "r r r", "krk", "krk", "krk", "rak", "rak", "ark", "ark", "kir", "kir", "kür", "kür", "erk", "erk", "kur", "kur", "rey", "rey", "arş", "arş", "yer", "yer", "ter", "ter", "kar", "kar", "rum", "rum", "art", "art", "ere", "ere", "ara", "ara", "iri", "iri", "kır", "kır", "kıra", "kıra", "şer", "şer", "ray", "ray", "ter", "tere", "tara", "tarak", "kart", "karta", "uru", "kuru", "ürk", "kürk", "kürkü", "türk", "türkü", "yer,", "yeri", "yerim", "ye", "kürküm", "ye", "reklam", "et", "reklam", "et", "rayı", "arka", "arkaya", "atar", "R R R", "Rak", "Rak", "Ray", "Ray", "Rey", "Rey" }; myColors = new Color[] {
        new Color(4 / 255f, 95 / 255f, 58 / 255f),
        new Color(246 / 255f, 153 / 255f, 5 / 255f),
        new Color(196 / 255f, 50 / 255f, 53 / 255f),
        new Color(68 / 255f, 210 / 255f, 184 / 255f),
        new Color(239 / 255f, 34 / 255f, 137 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("CuteGirl");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("3");
                break;
            case "Level8":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "il", "ili", "ey", "eye", "kır", "kır", "ırk", "ırk", "rum", "rum", "yakaya", "Rüya", "şakayla", "tüm", "iki", "kutu", "elmayı", "yemiş", "s s s", "ksk", "ksk", "sek", "sek", "sık", "sık", "kıs", "kıs", "aks", "aks", "rus", "rus", "sur", "sur", "süs", "süs", "ses", "ses", "kas", "kas", "tas", "tas", "sat", "sat", "set", "set", "sit", "sit", "süt", "süt", "üst", "üst", "kes", "kes", "aks", "aks", "aksa", "aksa", "sur", "sur", "sura", "sura", "surat", "surat", "say", "say", "sayı", "sayı", "ses", "ses", "sesi", "sesi", "sesim", "sesim", "sami", "masa", "masa", "et", "sattı", "sarı", "resmi", "saraya", "al", "kısa", "kısas", "sirk", "S S S", "Sat", "Sak", "kas", "Salı", "Sarı", "sara", "Sara" }; myColors = new Color[] {
        new Color(4 / 255f, 95 / 255f, 58 / 255f),
        new Color(246 / 255f, 153 / 255f, 5 / 255f),
        new Color(196 / 255f, 50 / 255f, 53 / 255f),
        new Color(68 / 255f, 210 / 255f, 184 / 255f),
        new Color(239 / 255f, 34 / 255f, 137 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("CuteGirl");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("3");
                break;
            case "Level9":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "al", "alı", "ay", "ayı", "ırk", "ırk", "sık", "sık", "sır", "sır", "saraya", "Sami", "şakayla", "tüm", "iki", "kutu", "elmayı", "yemiş", "c c c", "aca", "aca", "aca", "cay", "cay", "sac", "sac", "cam", "cam", "cem", "cem", "cim", "cim", "cik", "cik", "cuk", "cuk", "ece", "ece", "uca", "uca", "cet", "cet", "cır", "cır", "cer", "cer", "ucu", "ucu", "cak", "cak", "cek", "cek", "acı", "acı", "cam", "cam", "cami", "cami", "ece", "ece", "ecel", "ecel", "eceli", "eceli", "cak", "cak", "caka", "caka", "acı", "acı", "acım", "acım", "acıma", "acıma", "sarı", "amcama", "caka", "satmış", "cem", "cam", "tak", "aca", "acar", "cari", "cici", "cüce", "cüce", "acele", "C C C", "Cam", "Cem", "Camcı", "Cemal", "camcıya", "cam", "satmış" }; myColors = new Color[] {
        new Color(4 / 255f, 95 / 255f, 58 / 255f),
        new Color(246 / 255f, 153 / 255f, 5 / 255f),
        new Color(196 / 255f, 50 / 255f, 53 / 255f),
        new Color(68 / 255f, 210 / 255f, 184 / 255f),
        new Color(239 / 255f, 34 / 255f, 137 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("CuteGirl");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("3");
                break;
            case "Level10":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "al", "alı", "ay", "kır", "kır", "sır", "sır", "cay", "cay", "cam", "cam", "Celil", "şakayla", "tüm", "iki", "kutu", "elmayı", "yemiş", "z z z", "kzk", "kzk", "kzk", "kaz", "kaz", "kez", "kez", "zam", "zam", "arz", "arz", "zar", "zar", "zır", "zır", "zıt", "zıt", "zem", "zem", "yaz", "yaz", "yüz", "yüz", "tuz", "tuz", "muz", "muz", "zül", "zül", "zum", "zum", "aza", "aza", "muz", "muz", "muzu", "muzu", "tuz", "tuz", "tuzu", "tuzu", "tuzum", "tuzum", "eze", "eze", "ezer", "ezer", "aza", "aza", "azar", "azar", "yazar", "yazar", "Cam", "azar", "azar", "artmış", "raz", "razı", "yaz", "yazı", "yüz", "yüzü", "üz", "üzüm", "zeki", "siz", "Z Z Z", "Zam", "Zıt", "Zil", "Zeki", "iki", "elma", "yemiş" }; myColors = new Color[] {
        new Color(123 / 255f, 84 / 255f, 151 / 255f),
        new Color(254 / 255f, 205 / 255f, 69 / 255f),
        new Color(152 / 255f, 212 / 255f, 39 / 255f),
        new Color(234 / 255f, 85 / 255f, 57 / 255f),
        new Color(97 / 255f, 182 / 255f, 212 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("FlatBoy");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("4");
                break;
            case "Level11":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "al", "alı", "ay", "ayı", "kır", "kır", "acı", "acı", "saz", "saz", "zil", "zil", "Ziya", "şakayla", "iki", "kutu", "elmayı", "yemiş", "o o o", "aoa", "aoa", "aoa", "oka", "oka", "oya", "oya", "oyu", "oyu", "ota", "ota", "yoz", "yoz", "kor", "kor", "koy", "koy", "şok", "şok", "tok", "tok", "alo", "alo", "oto", "oto", "ola", "ola", "ora", "ora", "zor", "zor", "oku", "oku", "omo", "omo", "tok", "tok", "toka", "toka", "otu", "otu", "otum", "otum", "otumu", "otumu", "oka", "oka", "okka", "okka", "koy", "koy", "koya", "koya", "koyak", "koyak", "Oya", "şu", "koya", "toz", "atmış", "oya", "şu", "koca", "otoyu", "oymuş", "ora", "oraya", "ortaya", "otuz", "O O O", "Oya", "Olay", "Otuz", "Olcay", "okula", "kalem", "yolla" }; myColors = new Color[] {
        new Color(123 / 255f, 84 / 255f, 151 / 255f),
        new Color(254 / 255f, 205 / 255f, 69 / 255f),
        new Color(152 / 255f, 212 / 255f, 39 / 255f),
        new Color(234 / 255f, 85 / 255f, 57 / 255f),
        new Color(97 / 255f, 182 / 255f, 212 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("FlatBoy");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("4");
                break;
            case "Level12":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "al", "alı", "ay", "ayı", "ırk", "ırk", "koz", "koz", "sac", "saz", "oku", "oku", "Oya", "şakayla", "iki", "kutu", "elmayı", "yemiş", "d d d", "kdk", "kdk", "kdk", "kod", "kod", "dok", "dok", "tad", "tad", "dal", "dal", "diş", "diş", "del", "del", "dik", "dik", "dur", "dur", "dük", "dük", "dam", "dam", "adı", "adı", "dem", "dem", "duş", "duş", "ada", "ada", "dul", "dul", "diz", "diz", "ada", "ada", "adam", "adam", "dil", "dil", "dili", "dili", "dilim", "dilim", "kod", "kod", "kodu", "kodu", "dal", "dal", "dala", "dala", "dalar", "dalar", "doktor", "adım", "adım", "aradım", "dadımı", "odama", "almadım", "dik", "dil", "doz", "doku", "dokuz", "damla", "dayı", "D D D", "Dal", "Dil", "Doku", "Dolu", "dolu", "Dilim", "dilim" }; myColors = new Color[] {
        new Color(123 / 255f, 84 / 255f, 151 / 255f),
        new Color(254 / 255f, 205 / 255f, 69 / 255f),
        new Color(152 / 255f, 212 / 255f, 39 / 255f),
        new Color(234 / 255f, 85 / 255f, 57 / 255f),
        new Color(97 / 255f, 182 / 255f, 212 / 255f)};
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("FlatBoy");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("4");
                break;
            case "Level13":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "al", "alı", "ay", "ayı", "sır", "sır", "oda", "oda", "caz", "caz", "diz", "diz", "Dede", "şakayla", "iki", "kutu", "elmayı", "yemiş", "n n n", "mnm", "mnm", "mnm", "nam", "nam", "man", "man", "zon", "zon", "anı", "anı", "nal", "nal", "ney", "ney", "ana", "ana", "ona", "ona", "nem", "nem", "can", "can", "son", "son", "şan", "şan", "sen", "sen", "naz", "naz", "ünü", "ünü", "eni", "eni", "ten", "ten", "teni", "teni", "sen", "sen", "seni", "seni", "senin", "senin", "zon", "zon", "zona", "zona", "ana", "ana", "anam", "anam", "anamı", "nalan", "kalan", "naneyi", "de", "yemiş", "nane", "suyu", "kaynadı", "nermin", "annemin", "tonton", "ellerini", "uzun", "uzun", "sıktı", "N N N", "Nam", "Ney", "Naz", "Narı", "tane", "tane", "al" }; myColors = new Color[] {
        new Color(200 / 255f, 168 / 255f, 48 / 255f),
        new Color(138 / 255f, 28 / 255f, 89 / 255f),
        new Color(252 / 255f, 226 / 255f, 192 / 255f),
        new Color(10 / 255f, 61 / 255f, 0 / 255f),
        new Color(138 / 255f, 93 / 255f, 150 / 255f)};
                animatorY = 1.8f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Dino");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("5");
                break;
            case "Level14":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "su", "su", "de", "der", "kor", "kor", "caz", "caz", "diz", "diz", "nam", "nam", "Naz", "şakayla", "iki", "kutu", "elmayı", "yemiş", "ğ ğ ğ", "eğe", "eğe", "eğe", "yeğ", "yeğ", "yağ", "yağ", "iği", "iği", "iğe", "iğe", "değ", "değ", "sağ", "sağ", "dağ", "dağ", "ağa", "ağa", "tuğ", "tuğ", "yuğ", "yuğ", "ağı", "ağı", "sığ", "sığ", "ağu", "ağu", "tığ", "tığ", "yığ", "yığ", "oğa", "oğa", "eğe", "eğe", "eğer", "eğer", "sağ", "sağ", "sağa", "sağa", "sağar", "sağar", "ağa", "ağa", "ağar", "ağar", "tuğ", "tuğ", "tuğu", "tuğu", "tuğun", "tuğun", "Eğeyi", "sağa", "doğru", "attı", "kuğular", "şu", "ağaca", "tünedi", "Kağnılar", "Ağrı", "dağına", "ağır", "ağır", "soğan", "taşıyordu", "uğur", "dağa", "doğru", "atla", "ağır", "ağır", "koşmuş" }; myColors = new Color[] {
        new Color(200 / 255f, 168 / 255f, 48 / 255f),
        new Color(138 / 255f, 28 / 255f, 89 / 255f),
        new Color(252 / 255f, 226 / 255f, 192 / 255f),
        new Color(10 / 255f, 61 / 255f, 0 / 255f),
        new Color(138 / 255f, 93 / 255f, 150 / 255f)};
                animatorY = 1.8f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Dino");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("5");
                break;
            case "Level15":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "su", "su", "de", "dem", "kor", "kor", "caz", "caz", "dün", "dün", "eğe", "eğe", "Dede", "şakayla", "iki", "kutu", "elmayı", "yemiş", "ç ç ç", "aça", "aça", "aça", "çak", "çak", "çat", "çat", "çay", "çay", "çan", "çan", "çağ", "çağ", "çar", "çar", "açı", "açı", "taç", "taç", "çok", "çok", "seç", "seç", "çıt", "çıt", "içi", "içi", "çit", "çit", "çam", "çam", "çul", "çul", "çık", "çık", "çay", "çay", "çayı", "çayı", "çat", "çat", "çatı", "çatı", "çatık", "çatık", "açı", "açı", "açık", "açık", "çan", "çan", "çanı", "çanı", "çanın", "çanın", "çakı", "açık", "olduğu", "için", "kesti", "çam", "için", "çit", "arar", "çiçek", "için", "çimi", "üç", "kez", "çakıyla", "çizik", "çizik", "kes", "Ç Ç Ç", "Çok", "Çam", "Çeker" }; myColors = new Color[] {
        new Color(200 / 255f, 168 / 255f, 48 / 255f),
        new Color(138 / 255f, 28 / 255f, 89 / 255f),
        new Color(252 / 255f, 226 / 255f, 192 / 255f),
        new Color(10 / 255f, 61 / 255f, 0 / 255f),
        new Color(138 / 255f, 93 / 255f, 150 / 255f)};
                animatorY = 1.8f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Dino");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("5");
                break;
            case "Level16":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "su", "su", "de", "dem", "kor", "kor", "caz", "caz", "dağ", "dağ", "çad", "çad", "Çiler", "şakayla", "iki", "kutu", "elmayı", "yedi", "g g g", "igi", "igi", "igi", "gir", "gir", "giz", "giz", "gaz", "gaz", "giy", "giy", "git", "git", "gut", "gut", "gür", "gür", "güz", "güz", "gen", "gen", "ger", "ger", "güç", "güç", "geç", "geç", "gar", "gar", "gam", "gam", "güm", "güm", "gel", "gel", "gez", "gez", "gezi", "gezi", "gir", "gir", "gire", "gire", "giren", "giren", "gaz", "gaz", "gazı", "gazı", "gez", "gez", "gezi", "gezi", "gezin", "gezin", "gide", "gide", "iki", "gün", "geçmiş", "gemi", "geri", "geri", "gitti", "gece", "gelen", "gelin", "alayı", "ertesi", "günü", "geri", "gitmiş", "G G G", "Gar", "Gemi", "Geç", "Gece" }; myColors = new Color[] {
        new Color(255 / 255f, 248 / 255f, 93 / 255f),
        new Color(147 / 255f, 195 / 255f, 207 / 255f),
        new Color(151 / 255f, 189 / 255f, 137 / 255f),
        new Color(255 / 255f, 194 / 255f, 17 / 255f),
        new Color(58 / 255f, 33 / 255f, 17 / 255f)};
                animatorY = 2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("TempleBoy");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("6");
                break;
            case "Level17":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "su", "su", "de", "değ", "kor", "kor", "caz", "caz", "dağ", "dağ", "geç", "geç", "Gani", "şakayla", "iki", "kutu", "elmayı", "yemiş", "h h h", "lhl", "lhl", "lhl", "hal", "hal", "hol", "hol", "hay", "hay", "hot", "hot", "has", "has", "his", "his", "hor", "hor", "şah", "şah", "leh", "leh", "hiç", "hiç", "ham", "ham", "hem", "hem", "ahu", "ahu", "ahı", "ahı", "mah", "mah", "han", "han", "hor", "hor", "hora", "hora", "hat", "hat", "hata", "hata", "hatta", "hatta", "haç", "haç", "haçı", "haçı", "har", "har", "hara", "hara", "haram", "haram", "halis", "ham", "haşhaş", "yağı", "sattık", "halil", "hasta", "imiş", "hemen", "hemen", "herkes", "sahte", "altını", "sahicisi", "sandı", "H H H", "Hak", "Ham", "Hor", "Hale", "hasta", "halde" }; myColors = new Color[] {
        new Color(255 / 255f, 248 / 255f, 93 / 255f),
        new Color(147 / 255f, 195 / 255f, 207 / 255f),
        new Color(151 / 255f, 189 / 255f, 137 / 255f),
        new Color(255 / 255f, 194 / 255f, 17 / 255f),
        new Color(58 / 255f, 33 / 255f, 17 / 255f)};
                animatorY = 2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("TempleBoy");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("6");
                break;
            case "Level18":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "su", "su", "de", "den", "hor", "hor", "caz", "caz", "dağ", "dağ", "hal", "hal", "hami", "şakayla", "iki", "kutu", "elmayı", "yemiş", "v v v", "eve", "eve", "eve", "ver", "ver", "dev", "dev", "yiv", "yiv", "vay", "vay", "nev", "nev", "yuv", "yuv", "vur", "vur", "evi", "evi", "sev", "sev", "hav", "hav", "ova", "ova", "vat", "vat", "var", "var", "van", "van", "vın", "vın", "avı", "avı", "dev", "dev", "deve", "deve", "sev", "sev", "sevi", "sevi", "sevin", "sevin", "ava", "ava", "avam", "avam", "kav", "kav", "kavi", "kavi", "kavis", "kavis", "veli", "evde", "de", "kavga", "etmez", "verem", "evvelce", "çokmuş", "vakit", "varken", "evvela", "vize", "için", "vergiyi", "verdiler", "V V V", "Var", "Ver", "Veya", "Vize", "Vida", "gerekli" }; myColors = new Color[] {
        new Color(255 / 255f, 248 / 255f, 93 / 255f),
        new Color(147 / 255f, 195 / 255f, 207 / 255f),
        new Color(151 / 255f, 189 / 255f, 137 / 255f),
        new Color(255 / 255f, 194 / 255f, 17 / 255f),
        new Color(58 / 255f, 33 / 255f, 17 / 255f)};
                animatorY = 2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("TempleBoy");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("6");
                break;
            case "Level19":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "su", "suğ", "de", "den", "hor", "hor", "caz", "caz", "dağ", "dağ", "vah", "vah", "Veli", "şakayla", "iki", "kutu", "elmayı", "yemiş", "b b b", "mbm", "mbm", "mbm", "bam", "bam", "bim", "bim", "bum", "bum", "bom", "bom", "ben", "ben", "bin", "bin", "bar", "bar", "bir", "bir", "bor", "bor", "bek", "bek", "baş", "baş", "aba", "aba", "ebe", "ebe", "bil", "bil", "bul", "bul", "oba", "oba", "bal", "bal", "balı", "balı", "bez", "bez", "beze", "beze", "bezen", "bezen", "ban", "ban", "bana", "bana", "bin", "bin", "bine", "bine", "binek", "binek", "baba", "kaba", "saba", "olanları", "araba", "ile", "bize", "yollar", "bu", "biberler", "bazen", "bana", "biraz", "buruk", "tat", "veriyor", "B B B", "Bam", "Bal", "Baş", "Boya", "Bora", "benzer" }; myColors = new Color[] {
        new Color(205 / 255f, 245 / 255f, 255 / 255f),
        new Color(178 / 255f, 16 / 255f, 65 / 255f),
        new Color(192 / 255f, 178 / 255f, 29 / 255f),
        new Color(193 / 255f, 65 / 255f, 88 / 255f),
        new Color(243 / 255f, 211 / 255f, 87 / 255f)};
                animatorY = 2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("AdventureGirl");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("7");
                break;
            case "Level20":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "eğ", "eğe", "de", "dem", "hor", "hor", "caz", "caz", "sav", "sav", "bor", "bor", "Bora", "şakayla", "iki", "kutu", "elmayı", "yemiş", "f f f", "ufu", "ufu", "ufu", "ful", "ful", "fil", "fil", "fer", "fer", "fay", "fay", "far", "far", "efe", "efe", "saf", "saf", "fob", "fob", "cif", "cif", "kof", "kof", "sof", "sof", "fos", "fos", "fiş", "fiş", "aft", "aft", "tef", "tef", "ruf", "ruf", "def", "def", "defa", "defa", "saf", "saf", "safi", "safi", "safir", "safir", "raf", "raf", "rafı", "rafı", "fer", "fer", "feri", "feri", "ferik", "ferik", "fakir", "fukara", "bu", "hafta", "fırtınaya", "fena", "yakalandı", "faiz", "farkı", "faturaya", "girerse", "bu", "defa", "fazla", "olur", "F F F", "Fil", "Faz", "Fay", "Fare", "Fayda", "sağladı" }; myColors = new Color[] {
        new Color(205 / 255f, 245 / 255f, 255 / 255f),
        new Color(178 / 255f, 16 / 255f, 65 / 255f),
        new Color(192 / 255f, 178 / 255f, 29 / 255f),
        new Color(193 / 255f, 65 / 255f, 88 / 255f),
        new Color(243 / 255f, 211 / 255f, 87 / 255f)};
                animatorY = 2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("AdventureGirl");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("7");
                break;
            case "Level21":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "git", "git", "hal", "hal", "eve", "eve", "bin", "bin", "saz", "saz", "fob", "fob", "Faik", "şakayla", "iki", "kutu", "elmayı", "yemiş", "p p p", "ypy", "ypy", "ypy", "yap", "yap", "ipi", "ipi", "kep", "kep", "pek", "pek", "pay", "pay", "pus", "pus", "poz", "poz", "epe", "epe", "çap", "çap", "put", "put", "pot", "pot", "sap", "sap", "pop", "pop", "hop", "hop", "top", "top", "vip", "vip", "pey", "pey", "peyi", "peyi", "pot", "pot", "pota", "pota", "potas", "potas", "pür", "pür", "püre", "püre", "pik", "pik", "pika", "pika", "pikap", "pikap", "pilli", "pikapta", "pop", "müziği", "çalıp", "peşpeşe", "oynadık", "papaz", "her", "pazar", "günü", "kepini", "giyip", "tepeye", "çıktı", "P P P", "Pak", "Pek", "Pil", "Para", "Pembe", "Pasta", }; myColors = new Color[] {
        new Color(205 / 255f, 245 / 255f, 255 / 255f),
        new Color(178 / 255f, 16 / 255f, 65 / 255f),
        new Color(192 / 255f, 178 / 255f, 29 / 255f),
        new Color(193 / 255f, 65 / 255f, 88 / 255f),
        new Color(243 / 255f, 211 / 255f, 87 / 255f)};
                animatorY = 2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("AdventureGirl");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("7");
                break;
            case "Level22":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "giz", "giz", "hol", "hol", "hav", "hav", "baz", "baz", "bor", "bor", "puf", "puf", "Peri", "şakayla", "iki", "kutu", "elmayı", "yemiş", "j j j", "uju", "uju", "uju", "ruj", "ruj", "jüt", "jüt", "bej", "bej", "tij", "tij", "jet", "jet", "jak", "jak", "jan", "jan", "jül", "jül", "jag", "jag", "jat", "jat", "jeo", "jeo", "jip", "jip", "jüp", "jüp", "jud", "jud", "jür", "jür", "fuj", "fuj", "tij", "tij", "tiji", "tiji", "jüt", "jüt", "jütü", "jütü", "jütün", "jütün", "jat", "jat", "jatı", "jatı", "jet", "jet", "jeti", "jeti", "jetin", "jetin", "jandarma", "bujiyi", "bulup", "pilotun", "prestijini", "korur", "janjanlı", "bej", "kumaş", "eski", "bagaja", "konmuş", "olabilir", "J J J", "Jal", "Jale", "Jip", "Judo", "Jak", "ajan", "marjı", "kapat" }; myColors = new Color[] {
        new Color(62 / 255f, 72 / 255f, 55 / 255f),
        new Color(255 / 255f, 127 / 255f, 42 / 255f),
        new Color(130 / 255f, 161 / 255f, 163 / 255f),
        new Color(255 / 255f, 204 / 255f, 0 / 255f),
        new Color(231 / 255f, 19 / 255f, 19 / 255f)};
                animatorY = 2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Santa");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("8");
                break;
            case "Level23":
                words = new string[] { "akü", "akü", "tak", "tak", "kem", "kem", "mil", "mil", "uyu", "uyu", "yaş", "yaş", "gir", "gir", "hem", "hem", "vah", "vah", "saz", "saz", "bej", "bej", "jet", "jet", "Jale", "şakayla", "iki", "kutu", "elmayı", "yemiş", "ö ö ö", "iöi", "iöi", "iöi", "öte", "öte", "öne", "öne", "öre", "öre", "ölü", "ölü", "köz", "köz", "göz", "göz", "ört", "ört", "ölç", "ölç", "örs", "örs", "özü", "özü", "sör", "sör", "önü", "önü", "sön", "sön", "bön", "bön", "yön", "yön", "fön", "fön", "örs", "örs", "örsü", "örsü", "göm", "göm", "gömü", "gömü", "gömüt", "gömüt", "ölü", "ölü", "ölüm", "ölüm", "yön", "yön", "yöne", "yöne", "yönet", "yönet", "öteki", "köy", "için", "özel", "görevli", "göndermek", "gerekmez", "önce", "göle", "düşen", "aracı", "görüp", "köye", "öyle", "geri", "dön", "Ö Ö Ö", "Öne", "Ökse", "Örtü", "Özen", "Ömer", "geldi" }; myColors = new Color[] {
        new Color(62 / 255f, 72 / 255f, 55 / 255f),
        new Color(255 / 255f, 127 / 255f, 42 / 255f),
        new Color(130 / 255f, 161 / 255f, 163 / 255f),
        new Color(255 / 255f, 204 / 255f, 0 / 255f),
        new Color(231 / 255f, 19 / 255f, 19 / 255f)};
                animatorY = 2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Santa");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("8");
                break;
            case "Level24":
                words = new string[] { "a a a", "ata", "atam", "atamı", "atamın", "çam", "çamlar", "çamlarımızı", "acı", "açı", "açım", "açtım", "açamam", "ana", "analar", "Analarımızı", "b b b", "bal", "bala", "balam", "balamı", "baş", "başlar", "başlarından", "boş", "boy", "boya", "boyam", "boyalı", "bak", "bakmış", "Bakmışlardı", "c c c", "cam", "cama", "camda", "camdan", "acı", "acılar", "acılarımdan", "can", "ucu", "ucun", "ucuna", "ucunda", "caz", "cazını", "Cazcınızdan", "ç ç ç", "çay", "çayı", "çayın", "çayıma", "çok", "çoktur", "çoğunlukla", "çap", "geç", "geçe", "geçen", "geçkin", "çöl", "çölden", "Çöllerinde", "d d d", "düz", "düze", "düzen", "düzeni", "ada", "adadan", "adasındaki", "dün", "dön", "döne", "dönem", "dönemi", "oda", "odamda", "Odamdakini", "e e e", "eli", "elin", "eline", "elinde", "ver", "vergim", "verginizin", "ebe", "ten", "tene", "tende", "tenden", "der", "derede", "Deredekini", "f f f", "ful", "fule", "fular", "fuları", "fon", "fondan", "fondakileri", "def", "far", "fark", "farkı", "farklı", "şef", "şeflik", "Şefliğinden", "g g g", "gör", "göre", "gören", "görgül", "göz", "gözden", "gözlerinize", "gül", "güz", "güze", "güzel", "güzeli", "geç", "geçmiş", "Geçmişsiniz", "ğ ğ ğ", "eğe", "eğer", "eğeri", "eğerde", "doğ", "doğrul", "doğrultudan", "yağ", "sağ", "sağa", "sağda", "sağdan", "çağ", "yağmur", "Yağmurlarla", };
                myColors = new Color[] {
        new Color(62 / 255f, 72 / 255f, 55 / 255f),
        new Color(255 / 255f, 127 / 255f, 42 / 255f),
        new Color(130 / 255f, 161 / 255f, 163 / 255f),
        new Color(255 / 255f, 204 / 255f, 0 / 255f),
        new Color(231 / 255f, 19 / 255f, 19 / 255f)};
                animatorY = 2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Santa");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("8");
                break;
            case "Level25":
                words = new string[] { "h h h", "hal", "hale", "halef", "halefi", "his", "hissem", "hissesinden", "ahu", "hak", "haki", "hakim", "hakime", "hay", "hayret", "Hayretimizi", "ı ı ı", "akı", "akım", "akımı", "akımın", "sır", "sırdaş", "sırdaşların", "acı", "kır", "kıra", "kıran", "kıranı", "yıl", "yılını", "Yılındakini", "i i i", "iki", "ikiz", "ikisi", "ikilik", "içi", "içinde", "içindekiler", "ile", "eli", "elime", "elimde", "bir", "birini", "Birincisini", "j j j", "jüt", "jütü", "jütün", "jütten", "jet", "jetten", "jetlerimiz", "jat", "ruj", "ruju", "rujda", "rujdan", "jüt", "jütler", "Jütlerinde", "k k k", "kaş", "kaşı", "kaşın", "kaşsız", "kan", "kansa", "kanınızdan", "kök", "kör", "körü", "körün", "körüne", "kıs", "kısmak", "Kısmayınız", "l l l", "del", "dele", "dalek", "dalsız", "kul", "kullan", "kullanmaya", "bal", "böl", "böle", "bölen", "bölmüş", "eli", "elimiz", "Elimizdeki", "m m m", "mum", "mumu", "mumun", "mumdan", "mor", "morali", "moralinden", "mor", "dam", "dama", "damda", "damdan", "ham", "hammal", "Hammalımız", "n n n", "nam", "namı", "namın", "namına", "dön", "dönmen", "dönmenizin", "bön", "nur", "nura", "nurda", "nurdan", "yan", "yanmış", "Yanmışının", "o o o", "bor", "boru", "borun", "boruna", "sor", "sorunu", "sorunumuzu", "oba", "kor", "koru", "korun", "korunu", "oto", "otobüs", "Otobüsünüz", "ö ö ö", "göl", "gölü", "gölün", "gölden", "ölü", "ölümü", "ölümsüzlüğü", "öge", "göz", "gözü", "gözün", "gözünü", "ölç", "ölçme", "Ölçmelerini" };
                myColors = new Color[] {
        new Color(116 / 255f, 21 / 255f, 42 / 255f),
        new Color(234 / 255f, 187 / 255f, 17 / 255f),
        new Color(251 / 255f, 250 / 255f, 232 / 255f),
        new Color(5 / 255f, 90 / 255f, 120 / 255f),
        new Color(172 / 255f, 109 / 255f, 94 / 255f)};
                animatorY = 2.2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Knight");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("9");
                break;
            case "Level26":
                words = new string[] { "p p p", "pay", "payı", "payım", "paydan", "top", "toplu", "toplumumuzu", "pas", "par", "para", "paran", "parayı", "pay", "payın", "Paylarınıza", "r r r", "der", "dere", "deren", "dereyi", "ray", "rayın", "raylarından", "ruj", "eri", "erit", "erite", "eriten", "sar", "sarar", "Sararlarmış", "s s s", "sek", "seke", "seken", "say", "saymak", "saymasının", "söz", "siz", "size", "sizde", "sizden", "sor", "sormak", "Sorusundan", "ş ş ş", "yaş", "yaşa", "yaşam", "yaşama", "boş", "boşta", "boştakileri", "diş", "işi", "işim", "işimi", "işimiz", "koş", "koşma", "Koşmasından", "t t t", "kat", "katı", "katış", "katışı", "tür", "türde", "türdekileri", "tos", "kot", "kota", "kotam", "kotası", "tip", "tipte", "Tiptedirler", "u u u", "ulu", "ulus", "ulusu", "ulusun", "kur", "kurmak", "kurusundan", "ucu", "sun", "sunu", "sunuş", "sunmuş", "vur", "vurgun", "Vurguncuyu", "ü ü ü", "sür", "sürü", "sürün", "sürsün", "düş", "düşüne", "düşünmüyor", "üçü", "tüy", "tüyü", "tüyün", "tüysüz", "dün", "dününü", "Dünümüzden", "v v v", "vur", "vura", "vursa", "vurgun", "kav", "kavgam", "kavgaların", "eve", "ver", "veri", "vergi", "vergim", "var", "vardır", "Varlığında", "y y y", "yay", "yayı", "yayın", "yayını", "say", "saymak", "sayılması", "yün", "yüz", "yüze", "yüzey", "yüzeye", "yen", "yeniye", "Yeniyseniz", "z z z", "zar", "zara", "zarar", "zararı", "zor", "zorluk", "zorlukları", "naz", "biz", "bizi", "bizim", "bizsiz", "zam", "zamsız", "Zamlarımız" };
                myColors = new Color[] {
        new Color(116 / 255f, 21 / 255f, 42 / 255f),
        new Color(234 / 255f, 187 / 255f, 17 / 255f),
        new Color(251 / 255f, 250 / 255f, 232 / 255f),
        new Color(5 / 255f, 90 / 255f, 120 / 255f),
        new Color(172 / 255f, 109 / 255f, 94 / 255f)};
                animatorY = 2.2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Knight");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("9");
                break;
            case "Level27":
                words = new string[] { "ayak", "Ayak", "araç", "Araç", "aksi", "Aksi", "ağaç", "Ağaç", "ata", "Ata", "baba", "Baba", "bebe", "Bebe", "bacı", "Bacı", "beni", "Beni", "bor", "Bor", "caka", "Caka", "cami", "Cami", "cari", "Cari", "ceni", "Ceni", "can", "Can", "çare", "Çare", "çoğu", "Çoğu", "çıta", "Çıta", "çatı", "Çatı", "çek", "Çek", "dede", "Dede", "dadı", "Dadı", "daha", "Daha", "dava", "Dava", "dün", "Dün", "eski", "Eski", "eksi", "Eksi", "etek", "Etek", "eser", "Eser", "eki", "Eki", "feza", "Feza", "feci", "Feci", "fena", "Fena", "fors", "Fors", "faz", "Faz", "gaye", "Gaye", "gece", "Gece", "göle", "Göle", "göçü", "Göçü", "göz", "Göz", "hane", "Hane", "harf", "Harp", "hata", "Hata", "hoca", "Hoca", "hiç", "Hiç", "ıtır", "Itır", "ılık", "Ilık", "ışık", "Işık", "ışın", "Işın", "ısı", "Isı", "ilim", "İlim", "isim", "İsim", "içel", "İçel", "irat", "İrat", "ilk", "İlk", "jale", "Jale", "jöle", "Jöle", "jane", "Jane", "jest", "Jest", "jüp", "Jüp", "kaza", "Kaza", "kara", "Kara", "kutu", "Kutu", "kuzu", "Kuzu", "kaç", "Kaç", "lale", "Lale", "lira", "Lira", "lise", "Lise", "loca", "Loca", "loş", "Loş" };
                myColors = new Color[] {
        new Color(116 / 255f, 21 / 255f, 42 / 255f),
        new Color(234 / 255f, 187 / 255f, 17 / 255f),
        new Color(251 / 255f, 250 / 255f, 232 / 255f),
        new Color(5 / 255f, 90 / 255f, 120 / 255f),
        new Color(172 / 255f, 109 / 255f, 94 / 255f)};
                animatorY = 2.2f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Knight");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("9");
                break;
            case "Level28":
                words = new string[] { "mora", "Mora", "moda", "Moda", "mert", "Mert", "maya", "Maya", "maç", "Maç", "nama", "Nama", "niye", "Niye", "nota", "Nota", "nine", "Nine", "net", "Net", "okul", "Okul", "otur", "Otur", "orta", "Orta", "ordu", "Ordu", "oba", "Oba", "özel", "Özel", "ölçü", "Ölçü", "ömür", "Ömür", "öncü", "Öncü", "ört", "Ört", "para", "Para", "paşa", "Paşa", "park", "Park", "pasa", "Pasa", "pul", "Pul", "rüya", "Rüya", "rica", "Rica", "rüşt", "Rüşt", "rast", "Rast", "rol", "Rol", "sarı", "Sarı", "sonu", "Sonu", "süre", "Süre", "sade", "Sade", "ses", "Ses", "şark", "Şark", "şişe", "Şişe", "şans", "Şans", "şura", "Şura", "şey", "Şey", "taze", "Taze", "türk", "Türk", "terk", "Terk", "töre", "Töre", "tür", "Tür", "usul", "Usul", "uçak", "Uçak", "uyku", "Uyku", "uyum", "Uyum", "ulu", "Ulu", "ülke", "Ülke", "ülkü", "Ülkü", "üret", "Üret", "üçlü", "Üçlü", "üye", "Üye", "vade", "Vade", "vali", "Vali", "veda", "Veda", "vana", "Vana", "vat", "Vat", "yazı", "Yazı", "yalı", "Yalı", "yöre", "Yöre", "yurt", "Yurt", "yön", "Yön", "zeki", "Zeki", "zamk", "Zamk", "zarf", "Zarf", "zona", "Zona", "zor", "Zor" };
                myColors = new Color[] {
        new Color(226 / 255f, 53 / 255f, 37 / 255f),
        new Color(252 / 255f, 237 / 255f, 30 / 255f),
        new Color(39 / 255f, 124 / 255f, 153 / 255f),
        new Color(225 / 255f, 245 / 255f, 252 / 255f),
        new Color(255 / 255f, 113 / 255f, 0 / 255f)};
                animatorY = 2.0f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Robot");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("10");
                break;
            case "Level29":
                words = new string[] { "a4a", "a4a", "4a", "4a", "4", "44", "atkı", "4", "arı", "444", "k7k", "k7k", "7k", "7k", "7", "77", "askı", "7", "kat", "777", "e3e", "e3e", "3e", "3e", "3", "33", "yeke", "3", "tek", "333", "m8m", "m8m", "8m", "8m", "8", "88", "uçak", "8", "mil", "888", "i2i", "i2i", "2i", "2i", "2", "22", "koru", "2", "ton", "222", "l9l", "l9l", "9l", "9l", "9", "99", "araç", "9", "yıl", "999", "a5a", "a5a", "5a", "5a", "5", "55", "karo", "5", "köy", "555", "y0y", "y0y", "0y", "0y", "0", "00", "yama", "0", "lif", "000", "k6k", "k6k", "6k", "6k", "6", "66", "keçe", "6", "sim", "666", "u1u", "u1u", "1u", "1u", "1", "11", "adam", "1", "taş", "111" }; myColors = new Color[] {
        new Color(226 / 255f, 53 / 255f, 37 / 255f),
        new Color(252 / 255f, 237 / 255f, 30 / 255f),
        new Color(39 / 255f, 124 / 255f, 153 / 255f),
        new Color(225 / 255f, 245 / 255f, 252 / 255f),
        new Color(255 / 255f, 113 / 255f, 0 / 255f)};
                animatorY = 2.0f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Robot");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("10");
                break;
            case "Level30":
                words = new string[] { ". . .", "l.l", "l.l", "l.l", "tl.", "tl.", "al.", "al.", "el.", "el.", ", , ,", "y,y", "y,y", "y,y", "ay,", "ay,", "ey,", "ey,", "uy", "uy,", "Rüya", "elma,", "portakal,", "armut", "ve", "havuç", "yemiş.", ";;;", "y;y", "y;y", "al;", "ek;", ":::", "y:y", "y:y", "et:", "ay:", "???", "l?l", "l?l", "at?", "kal?", "yemek;", "meyve:", "nerede?" }; myColors = new Color[] {
        new Color(226 / 255f, 53 / 255f, 37 / 255f),
        new Color(252 / 255f, 237 / 255f, 30 / 255f),
        new Color(39 / 255f, 124 / 255f, 153 / 255f),
        new Color(225 / 255f, 245 / 255f, 252 / 255f),
        new Color(255 / 255f, 113 / 255f, 0 / 255f)};
                animatorY = 2.0f;
                animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Robot");
                spawnee.GetComponent<Renderer>().sharedMaterial = Resources.Load<Material>("10");
                break;

        }
        animator.SetInteger("State", 0);
        animator = animator.GetComponent<Animator>();
        username = UserName.name;
        keyPressSound = GetComponent<AudioSource>();
        transform.position = new Vector3(-2, 3, -8);
        wordTextUI.transform.position = new Vector3(wordText.transform.position.x, wordText.transform.position.y, z);
        spawnee.transform.localScale = new Vector3(5, 1, 1);
        if1.Select();
        wordTextUI.richText = true;
        oldWordsList.text = "";
        scb.value = 1;
        animator.transform.position = new Vector3(-2, 0, 0);
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            sbText.text = "Merhaba " + username + ". Oyun boyunca ben ve arkadaşlarım sana yardımcı olacağız.";
        }
        else
        {
            sbText.text = "Merhaba " + username + ". Haydi yeni bölüme başlayalım.";
        }



    }
    public void showInitialSkor(int initSkor)
    {
        var iText = Instantiate(initialSkorText, new Vector3(-2, y + 2.5f, 0), spawnPos.rotation);
        if (initSkor < 0)
        {
            iText.GetComponent<TextMesh>().color = Color.red;
            iText.GetComponent<TextMesh>().text = initSkor.ToString();
        }
        else
        {
            iText.GetComponent<TextMesh>().color = new Color(0, 187 / 255f, 51 / 255f);
            iText.GetComponent<TextMesh>().text = "+" + initSkor.ToString();
        }

    }

    private void ShowSB(string message)
    {
        spPopSound.Play();
        speechBaloon.transform.position = new Vector3(speechBaloon.transform.position.x, spawnPos.transform.position.y + 200, speechBaloon.transform.position.z);
        sbText.text = message;
        speechBaloon.SetActive(true);


    }
    public void ValueChangeCheck()
    {
        isChange = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && !speechBaloon.activeSelf)
        {
            ShowSB("Sol 'Üst(Shift)' tuşuyla beraber sağ el harflerini kullanmalısın.");
            if (rightHand.activeSelf)
            {
                isHandsActive = true;
                leftHand.SetActive(false);
            }
            else
            {

                rightHand.SetActive(true);
            }

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speechBaloon.SetActive(false);
            if (isHandsActive)
            {
                leftHand.SetActive(true);
            }
            else
            {
                rightHand.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightShift) && !speechBaloon.activeSelf)
        {
            ShowSB("Sağ 'Üst(Shift)' tuşuyla beraber sol el harflerini kullanmalısın.");
            if (leftHand.activeSelf)
            {
                isHandsActive = true;
                rightHand.SetActive(false);
            }
            else
            {

                leftHand.SetActive(true);
            }

        }
        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            speechBaloon.SetActive(false);
            if (isHandsActive)
            {
                rightHand.SetActive(true);
            }
            else
            {
                leftHand.SetActive(false);
            }
        }

      //  if (IsCapsLockOn && !speechBaloon.activeSelf)
      //  {
     //       ShowSB("'BÜYÜK(Capslock)' tuşunu kapatıp, büyük harfleri 'Üst(Shift)' tuşlarıyla yazmalısın.");
     //       if (!capslockOnSound.isPlaying)
    //        {
      //          capslockOnSound.Play();
        //    }
      //  }

        if ((words.Length - count + 1) % 30 == 0 && count > 10 && (words.Length - count + 1) != 0)
        {
            if (!speechBaloon.activeSelf)
            {
                ShowSB("Tebrikler " + username + " ! " + skor + " Puana ulaştık.");
            }
            animator.SetInteger("State", 2);

        }
        else if ((words.Length - count + 1) == Mathf.Abs(10 - words.Length))
        {
            if (!speechBaloon.activeSelf)
            {
                ShowSB("Yardım almak için sağ taraftaki klavye sembolüne tıklayabilirsin.");
            }
        }
        else if ((words.Length - count + 1) == Mathf.Abs(30 - words.Length))
        {
            if (!speechBaloon.activeSelf)
            {
                ShowSB("Harfleri doğru parmakla yazman çok önemli " + username + ".");
            }
        }
        else if ((words.Length - count + 1) == words.Length / 2)
        {
            if (!speechBaloon.activeSelf)
            {
                ShowSB("Tebrikler " + username + ". Bölümün yarısını bitirdik.");
            }
        }
        else if ((words.Length - count + 1) == Mathf.Abs(70 - words.Length))
        {
            if (!speechBaloon.activeSelf)
            {
                ShowSB("Bravo " + username + "! İlerlemeye devam et.");
            }
        }


        wordTextUI.fontSize = wordText.fontSize;
        if (skor != 0)
        {
            skorText.text = skor.ToString();
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if1.ActivateInputField();
            if1.caretPosition = if1.text.Length;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {



            if (currentWord.Length > 0 && currentWord.Contains(" "))
            {
                int wordSpaceCount = currentWord.Split(' ').Length - 1;
                int inputSpaceCount = if1.text.Split(' ').Length - 1;


                if (wordSpaceCount == inputSpaceCount - 1)
                {
                    //  Debug.Log("input space: " + inputSpaceCount.ToString());
                    // Debug.Log("word space: " + wordSpaceCount.ToString());                


                    includeSpace = false;
                }
                else
                {
                    if (if1.text.Length > currentWord.IndexOf(' ') + 1 && !if1.text.Substring(0, if1.text.Length - 2).Contains(" "))
                    {
                        includeSpace = false;
                    }
                    else { includeSpace = true; }


                }







            }
            else
            {
                includeSpace = false;
            }


        }




        if (!thumbsOnButton.IsActive())
        {
            string forRightThumb = "12345fFgGğĞıIoOuUiİeEaAüÜjJöÖvVcCçÇ";
            char lastChar = '-';
            if (currentWord.Length > 0)
            {
                lastChar = currentWord[currentWord.Length - 1];
            }







            if (currentWord.Length == if1.text.Length)
            {
                if (forRightThumb.Contains(lastChar.ToString()))
                {
                    leftThumb.SetActive(false);
                    rightThumb.SetActive(true);
                }
                else
                {
                    leftThumb.SetActive(true);
                    rightThumb.SetActive(false);
                }
            }
            else
            {
                if (currentWord.Length > 0 && currentWord.Contains(" ") && if1.text.Length > 0)
                {
                    if (if1.text.Length <= currentWord.Length && currentWord[if1.text.Length] == ' ')
                    {
                        if (forRightThumb.Contains(currentWord[if1.text.Length - 1].ToString()))
                        {
                            leftThumb.SetActive(false);
                            rightThumb.SetActive(true);
                        }
                        else
                        {
                            leftThumb.SetActive(true);
                            rightThumb.SetActive(false);
                        }
                    }
                }

            }




           
          

            if ((!handsOnButton.IsActive() && leftThumb.activeSelf == true) || (!handsOnButton.IsActive() && rightThumb.activeSelf == true))
            {
                leftHand.SetActive(false);
                rightHand.SetActive(false);

            }





            if (Input.GetKey(KeyCode.Space))
            {
                leftThumb.SetActive(false);
                rightThumb.SetActive(false);
                if (!handsOnButton.IsActive())
                {
                    leftHand.SetActive(true);
                    rightHand.SetActive(true);

                }
                else
                {
                    leftHand.SetActive(false);
                    rightHand.SetActive(false);
                }
            
            }

        }







        if (!includeSpace && Input.GetKeyUp(KeyCode.Space))//////////////////////////////////////////////////////////////////////////////////////////////////////
        {







            animator.transform.position = new Vector3(0, animatorY, 0);
            wordTextUI.text = "";
            if (count == 1)
            {
                speechBaloon.SetActive(false);
                getNewWord(0);
            }

            if1.selectionFocusPosition = if1.text.Length;
            if (checkWords())
            {
                trueWordSound.Play();

                if (!currentWord.Contains(" "))
                {
                    if (words[count - 1].Length >= 5 && words[count - 1].Length <= 6)
                    {
                        Instantiate(starPref, new Vector3(-2, 3.5f, -1), spawnPos.rotation);

                    }
                    else if (words[count - 1].Length >= 7 && words[count - 1].Length <= 8)
                    {
                        Instantiate(starPref, new Vector3(-5, 3.5f, -1), spawnPos.rotation);
                        Instantiate(starPref, new Vector3(1, 3.5f, -1), spawnPos.rotation);
                    }
                    else if (words[count - 1].Length >= 9)
                    {
                        Instantiate(starPref, new Vector3(-5, 3.5f, -1), spawnPos.rotation);
                        Instantiate(starPref, new Vector3(-1, 3.5f, -1), spawnPos.rotation);
                        Instantiate(starPref, new Vector3(2, 3.5f, -1), spawnPos.rotation);
                    }
                }




                if (isWrong)
                {
                    oldWordsList.text += "<b><color=#FF0000>" + words[count - 1] + "</color></b>\n";
                    isWrong = false;

                }
                else
                {
                    oldWordsList.text += "<color=#008000>" + words[count - 1] + "</color>\n";
                }

                if (count > 0 && count % 9 == 0)
                {
                    scb.value -= 0.080f;
                }

                if (count++ < 11)
                {
                    steps[count - 2] = Instantiate(spawnee, new Vector3(-2, y += 0.5f, z++), spawnPos.rotation) as GameObject;
                    steps[count - 2].GetComponent<Renderer>().material.color = myColors[count % 5];
                }
                else
                {

                    for (int i = 0; i < steps.Length - 2; i++)
                    {

                        steps[i].GetComponent<Renderer>().material.color = steps[i + 1].GetComponent<Renderer>().material.color;
                    }
                    steps[steps.Length - 2].GetComponent<Renderer>().material.color = myColors[count % 5];
                }


                stepCountText.text = (words.Length - count + 1).ToString();
                getNewWord(count - 1);
                if (count < 12)
                {
                    transform.position = new Vector3(transform.position.x, wordTextUI.transform.position.y + 2, transform.position.z - 0.1f);
                    wordText.transform.position = new Vector3(wordText.transform.position.x, y + 1, z);

                }
                wordTextUI.transform.position = new Vector3(wordText.transform.position.x, wordText.transform.position.y, wordText.transform.position.z);

                if1.text = "";



            }
            else
            {

                if (count != 1)
                {
                    isWrong = true;
                    skor -= currentWord.Length * 2;
                    showInitialSkor(-1 * (currentWord.Length * 2));
                    animator.SetInteger("State", 1);
                }

                if1.text = "";
                if1.ActivateInputField();
            }


        }
        if1.onValueChanged.AddListener(delegate { ValueChangeCheck(); });

        if (isChange && Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Return) && !Input.GetKeyDown(KeyCode.RightShift) && !Input.GetKeyDown(KeyCode.LeftShift) && !Input.GetKeyDown(KeyCode.CapsLock) && !Input.GetKeyDown(KeyCode.Backspace))
        {
            isChange = false;
            animator.SetInteger("State", 3);

            try
            {
                if (Input.inputString.Equals(currentWord[if1.text.Length - 1].ToString()))
                {
                    keyPressSound.Play();
                    wordTextUI.text += "<color=#008000>" + Input.inputString + "</color>";
                    skor++;
                    showInitialSkor(1);
                }
                else
                {
                    wrongKeySound.Play();
                    wordTextUI.text += "<color=#FF0000>" + Input.inputString + "</color>";
                    isWrong = true;
                    animator.SetInteger("State", 1);



                }
            }
            catch (IndexOutOfRangeException)
            {
                wordTextUI.text += "<color=#FF0000>" + Input.inputString + "</color>";
            }
            catch (NullReferenceException)
            {

            }

        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            isWrong = true;
            if (if1.text.Length < 1)
            {
                wordTextUI.text = "";
            }

            try
            {
                wordTextUI.text = if1.text;
                skor -= 2;
                showInitialSkor(-2);

            }
            catch (ArgumentOutOfRangeException)
            {


            }
            if (if1.text == wordText.text)
            {
                wordTextUI.text = "<color=#008000>" + if1.text + "</color>";
            }

        }
        if (Input.GetKeyUp(KeyCode.Backspace) && if1.text.Length < 1)
        {
            wordTextUI.text = "";




        }/////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }



    private void getNewWord(int wordİndex)
    {
        if (wordİndex > words.Length - 1)
        {
            totalSkor += skor;
            hst.AddHighscoreEntry(skor, username);
            //Bölüm sonu
            wordText.text = "";
            currentWord = "";
            isFinish = true;
            levelCompleteSound.Play();
            gameManager.CompleteLevel();


        }

        else
        {

            wordText.text = words[wordİndex];
            currentWord = words[wordİndex];

        }

    }



    private void OnApplicationQuit()
    {
        if (totalSkor != 0)
        {
            hstm.AddHighscoreEntry(totalSkor, username);

        }
        if (!isFinish && skor != 0)
        {
            hst.AddHighscoreEntry(skor, username);
        }
        spawnee.transform.localScale = new Vector3(5, 1, 1);
    }

    private bool checkWords()
    {

        return currentWord == if1.text.TrimEnd();
    }

}
