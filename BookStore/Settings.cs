namespace BookStore.Properties {


    // Bu sınıf ayarlar sınıfında belirli olayları işleyebilmenizi sağlar:
    //  SettingChanging olayı, bir ayarın değeri değiştirilmeden önce tetiklenir.
    //  PropertyChanged olayı, bir ayarın değeri değiştirildikten sonra tetiklenir.
    //  SettingsLoaded olayı ayar değerleri yüklendikten sonra oluşturulur.
    //  SettingsSaving olayı, ayar değerleri kaydedilmeden önce tetiklenir.
    /*! \class Settings
     *  \brief It is Settings class.
     */
    internal sealed partial class Settings {
        
        public Settings() {
            // // Ayarları kaydetmek ve değiştirmek üzere olay işleyicileri eklemek için alttaki açıklama satırlarını kaldırın:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        /*! \fn void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e)
        *  \brief A changing event handler listener.
        *  \details It is used to make a change in setting.
        *  \param sender it is an object.
        *  \param e it is a SettingChangingEventArgs object.
        *  \return void
        */
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // SettingChangingEvent olayını işleyebilmek için buraya kod ekleyin.
        }

        /*! \fn void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
        *  \brief A saving event handler listener.
        *  \details It is used to save change in setting.
        *  \param sender it is an object.
        *  \param e it is a CancelEventArgs object.
        *  \return void
        */
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // SettingsSaving olayını işleyebilmek için buraya kod ekleyin.
        }
    }
}
