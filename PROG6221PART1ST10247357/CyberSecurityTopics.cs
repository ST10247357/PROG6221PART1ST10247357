using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221PART1ST10247357
{
    class CyberSecurityTopics
    {
    // Create a dictionary to store cybersecurity topics and their descriptions
    public static Dictionary<string, string> Topics { get; set; } = new Dictionary<string, string>();

    static CyberSecurityTopics()
    {
        // Add cybersecurity topics and their explanations to the dictionary
        Topics.Add("Phishing", "Phishing is a type of cyber attack where attackers trick you into giving away sensitive " +
                               "information—like passwords, credit card numbers, or personal data—by pretending to be a trusted source, usually " +
                               "through fake emails, messages, or websites.");

        Topics.Add("Safe Browsing", "Safe browsing means using the internet in a way that protects your personal information " +
                                    "and devices from threats like viruses, phishing sites, and scams. It includes avoiding suspicious links, using secure websites " +
                                    "(https), and keeping your browser updated.");

        Topics.Add("Password Safety", "Password safety involves creating strong, unique passwords and keeping them private. Use a mix of letters, " +
                                      "numbers, and symbols, avoid using the same password for multiple accounts, and consider using a password manager to keep them secure.");

        Topics.Add("Malware", "Malware is malicious software designed to harm or exploit any device, service, or network. It includes " +
                              "viruses, worms, trojans, ransomware, and spyware.");

        Topics.Add("Firewalls", "A firewall is a network security system that monitors and controls incoming and outgoing network " +
                                "traffic based on predetermined security rules, acting as a barrier between a trusted and an untrusted network.");

        Topics.Add("Two-Factor Authentication", "Two-factor authentication (2FA) adds an extra layer of security by requiring not only " +
                                                 "a password but also a second form of verification—like a code sent to your phone or a fingerprint scan.");

        Topics.Add("Social Engineering", "Social engineering is a tactic where attackers manipulate people into revealing confidential " +
                                          "information. It often involves impersonation, fear tactics, or building false trust.");

        Topics.Add("Software Updates", "Keeping software updated ensures you have the latest security patches and bug fixes. " +
                                        "Hackers often exploit outdated software to gain unauthorized access.");

        Topics.Add("Data Encryption", "Data encryption protects your information by converting it into unreadable code that can only " +
                                       "be deciphered with the correct key, keeping it safe during transmission or storage.");

        Topics.Add("Network Security", "Network security involves measures and technologies that protect the integrity, confidentiality, " +
                                        "and availability of data across your networks, such as firewalls, antivirus software, and intrusion detection systems.");
    }
  }
}
