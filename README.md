# Chimera Tool Mobile Phone Drivers Setup

A simple, automated, wizard-style installer for the complete collection of mobile phone drivers leaked from the Chimera Tool.

![Welcome Screen](https://github.com/user-attachments/assets/7c9be1b3-eae2-4f00-aaf0-4d1d3ee689f0)

---

## About The Project

This project provides a user-friendly Windows Forms installer to simplify the process of installing the comprehensive set of mobile phone drivers that were originally packaged with Chimera Tool. Manually installing dozens of drivers for various phone brands (Samsung, Huawei, LG, MTK, etc.) is a tedious and time-consuming task. This tool automates the entire process, saving time and ensuring all necessary drivers are installed correctly.

The application bundles all the driver files into a single executable. It then extracts them to a temporary location and uses the Windows `pnputil.exe` command-line utility to systematically install each driver from its `.inf` file, providing real-time feedback to the user.

### Built With
*   .NET 10 / C#
*   Windows Forms

---
## Features

*   **Wizard-Style Interface:** Easy-to-follow, step-by-step installation process.
*   **Automated Installation:** Extracts and installs all drivers with a few clicks. No manual searching for `.inf` files is needed.
*   **Comprehensive Driver Package:** Includes a wide variety of drivers for multiple mobile phone brands and chipsets.
*   **Administrator Elevation:** Automatically requests administrative privileges required for driver installation.
*   **Real-time Progress:** Displays detailed progress, showing which driver is currently being installed.
*   **Reboot Prompt:** Informs the user when a system restart is necessary and provides a convenient "Reboot Now" option.

---
## Getting Started

To use this installer, simply download and run the executable.

### Prerequisites
*   Windows Operating System (10, 11)
*   Administrator privileges

### Usage

1.  Download the latest `ChimeraToolMobilePhoneDriversSetup.exe` from the Releases section.
2.  Run the executable. The application will prompt for administrator rights, which are required for installing drivers.
3.  You will be greeted with the **Welcome** screen. Click `Next >` to proceed.
    ![Welcome to the Chimera Tool Mobile Phone Drivers Setup Wizard](https://github.com/user-attachments/assets/7c9be1b3-eae2-4f00-aaf0-4d1d3ee689f0)
4.  The installation process will begin automatically. The installer will first extract all driver files and then install them one by one. You can monitor the progress on the **Installing** screen.
    ![Installing drivers...](https://github.com/user-attachments/assets/744d1755-4427-4a1c-9eef-b9b2fec70651)
5.  Once all drivers are installed, the **Setup Finished** screen will appear. If a restart is required to finalize the installation, you will be notified.
6.  Click `Finish` to close the installer and restart your computer later, or click `Reboot Now` to restart immediately.
    ![Completing the setup](https://github.com/user-attachments/assets/0a5c304e-f381-4823-a5f3-5b8cef8fb9fe)

---
## How It Works

The application follows a straightforward logic:
1.  **Admin Check:** On startup, it verifies if it's running with administrator privileges. If not, it attempts to restart itself as an administrator.
2.  **Embedded Resources:** The entire collection of drivers is stored in a compressed `.zip` archive embedded within the installer's executable.
3.  **Extraction:** At the start of the installation, the application extracts the contents of the embedded zip archive to a temporary folder in the user's `Temp` directory (`%TEMP%`).
4.  **Driver Installation:** The installer scans the temporary directory for all `*.inf` files. It then iterates through this list and executes the `pnputil.exe` command for each file to add and install the driver package to the Windows Driver Store.
    ```shell
    pnputil.exe /add-driver "C:\path\to\driver.inf" /install
    ```
5.  **UI Feedback:** Throughout the process, the installer logic sends updates to the user interface to show the current status, which file is being processed, and the overall progress.
6.  **Cleanup:** After the installation is complete, the temporary directory containing the extracted driver files is deleted.
7.  **Completion:** The final screen notifies the user of the successful installation and prompts for a system reboot if necessary.

---
## License

Distributed under the MIT License. See `LICENSE` for more information.

---
## Acknowledgments
*   The original Chimera Tool for providing the comprehensive driver package.
*   The open-source community.