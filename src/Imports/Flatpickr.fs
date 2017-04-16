namespace Fable.Import

// open System
// open System.Text.RegularExpressions
// open Fable.Core
// open Fable.Import.JS
// open Fable.Import.Browser

// type [<AllowNullLiteral>] [<Import("*","Flatpickr")>] Flatpickr(element: U2<string, Element>, ?options: Flatpickr.Options) =
//     member __.changeMonth(month: float, isOffset: bool): unit = jsNative
//     member __.clear(): unit = jsNative
//     member __.close(): unit = jsNative
//     member __.destroy(): unit = jsNative
//     member __.formatDate(format: string, date: DateTime): string = jsNative
//     member __.jumpToDate(?date: Flatpickr.DateString): unit = jsNative
//     member __.``open``(): unit = jsNative
//     member __.parseDate(date: string): DateTime = jsNative
//     member __.redraw(): unit = jsNative
//     member __.set(option: string, value: obj): unit = jsNative
//     member __.setDate(date: U2<Flatpickr.DateString, ResizeArray<Flatpickr.DateString>>): unit = jsNative
//     member __.toggle(): unit = jsNative

// module Flatpickr =
//     type [<AllowNullLiteral>] Options =
//         abstract altFormat: string option with get, set
//         abstract altInput: bool option with get, set
//         abstract altInputClass: string option with get, set
//         abstract allowInput: bool option with get, set
//         abstract clickOpens: bool option with get, set
//         abstract dateFormat: U2<string, obj> option with get, set
//         abstract ``null``: obj with get, set
//         abstract defaultDate: U2<DateString, ResizeArray<DateString>> option with get, set
//         abstract disable: ResizeArray<DateRange> option with get, set
//         abstract enable: ResizeArray<DateRange> option with get, set
//         abstract enableTime: bool option with get, set
//         abstract enableSeconds: bool option with get, set
//         abstract hourIncrement: float option with get, set
//         abstract ``inline``: bool option with get, set
//         abstract maxDate: DateString option with get, set
//         abstract minDate: DateString option with get, set
//         abstract minuteIncrement: float option with get, set
//         abstract mode: Mode option with get, set
//         abstract nextArrow: string option with get, set
//         abstract noCalendar: bool option with get, set
//         abstract onChange: U2<EventCallback, ResizeArray<EventCallback>> option with get, set
//         abstract onClose: U2<EventCallback, ResizeArray<EventCallback>> option with get, set
//         abstract onOpen: U2<EventCallback, ResizeArray<EventCallback>> option with get, set
//         abstract onReady: U2<EventCallback, ResizeArray<EventCallback>> option with get, set
//         abstract onMonthChange: U2<EventCallback, ResizeArray<EventCallback>> option with get, set
//         abstract onYearChange: U2<EventCallback, ResizeArray<EventCallback>> option with get, set
//         abstract onValueUpdate: U2<EventCallback, ResizeArray<EventCallback>> option with get, set
//         abstract onDayCreate: U2<EventCallback, ResizeArray<EventCallback>> option with get, set
//         abstract prevArrow: string option with get, set
//         abstract shorthandCurrentMonth: bool option with get, set
//         abstract ``static``: bool option with get, set
//         abstract time_24hr: bool option with get, set
//         abstract utc: bool option with get, set
//         abstract weekNumbers: bool option with get, set
//         abstract wrap: bool option with get, set
//         abstract parseDate: date: string -> DateTime

//     and [<AllowNullLiteral>] DateString =
//         U2<DateTime, string>

//     and [<AllowNullLiteral>] DateRange =
//         U3<DateString, obj, Func<DateTime, bool>>

//     and [<AllowNullLiteral>] [<StringEnum>] Mode =
//         | Single | Multiple | Range

//     and [<AllowNullLiteral>] EventCallback =
//         Func<ResizeArray<DateTime>, string, Flatpickr, HTMLElement, unit>


