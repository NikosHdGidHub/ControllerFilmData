﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmDataBaseForm.Models.FilmModelData {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FilmDataBaseForm.Models.FilmModelData.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Название фильма слишком длинное.
        /// </summary>
        internal static string NameFilmIsLong {
            get {
                return ResourceManager.GetString("NameFilmIsLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Название фильма не может быть пустым.
        /// </summary>
        internal static string NameFilmIsNull {
            get {
                return ResourceManager.GetString("NameFilmIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Не смотрел.
        /// </summary>
        internal static string Rate0 {
            get {
                return ResourceManager.GetString("Rate0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Отвратительный фильм.
        /// </summary>
        internal static string Rate1 {
            get {
                return ResourceManager.GetString("Rate1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Плохой, неитересный фильм.
        /// </summary>
        internal static string Rate2 {
            get {
                return ResourceManager.GetString("Rate2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Средний, возможно потом повторно посмотрю.
        /// </summary>
        internal static string Rate3 {
            get {
                return ResourceManager.GetString("Rate3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Фильм местами заинтересовал, потрогал за душу.
        /// </summary>
        internal static string Rate4 {
            get {
                return ResourceManager.GetString("Rate4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Отличный фильм, много интересных моментов, обязательно когданибудь посмотрю ещё раз.
        /// </summary>
        internal static string Rate5 {
            get {
                return ResourceManager.GetString("Rate5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Один из лучших самых фильмов....
        /// </summary>
        internal static string Rate6 {
            get {
                return ResourceManager.GetString("Rate6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Неверно получены данные о рейтенге фильма.
        /// </summary>
        internal static string RateFilmIsNotCorrect {
            get {
                return ResourceManager.GetString("RateFilmIsNotCorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Просмотрен.
        /// </summary>
        internal static string StatusFilm0 {
            get {
                return ResourceManager.GetString("StatusFilm0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Смотрю.
        /// </summary>
        internal static string StatusFilm1 {
            get {
                return ResourceManager.GetString("StatusFilm1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Хочу посмотреть.
        /// </summary>
        internal static string StatusFilm2 {
            get {
                return ResourceManager.GetString("StatusFilm2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Неверно получены данные о статусе фильма.
        /// </summary>
        internal static string StatusFilmIsNotCorrect {
            get {
                return ResourceManager.GetString("StatusFilmIsNotCorrect", resourceCulture);
            }
        }
    }
}