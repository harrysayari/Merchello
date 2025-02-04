﻿namespace Merchello.Web.Models.ContentEditing
{
    using System.Globalization;

    using Merchello.Core;
    using Merchello.Core.Models;

    internal static class ExtendedDataExtensions
    {
        /// <summary>
        /// The add product variant values.
        /// </summary>
        /// <param name="extendedData">
        /// The extended data.
        /// </param>
        /// <param name="productVariant">
        /// The product variant.
        /// </param>
        public static void AddProductVariantValues(this ExtendedDataCollection extendedData, ProductVariantDisplay productVariant)
        {
            extendedData.SetValue(Constants.ExtendedDataKeys.ProductKey, productVariant.ProductKey.ToString());
            extendedData.SetValue(Constants.ExtendedDataKeys.ProductVariantKey, productVariant.Key.ToString());
            extendedData.SetValue(Constants.ExtendedDataKeys.CostOfGoods, productVariant.CostOfGoods.ToString(CultureInfo.InvariantCulture));
            extendedData.SetValue(Constants.ExtendedDataKeys.Weight, productVariant.Weight.ToString(CultureInfo.InvariantCulture));
            extendedData.SetValue(Constants.ExtendedDataKeys.Width, productVariant.Width.ToString(CultureInfo.InvariantCulture));
            extendedData.SetValue(Constants.ExtendedDataKeys.Height, productVariant.Height.ToString(CultureInfo.InvariantCulture));
            extendedData.SetValue(Constants.ExtendedDataKeys.Length, productVariant.Length.ToString(CultureInfo.InvariantCulture));
            extendedData.SetValue(Constants.ExtendedDataKeys.Barcode, productVariant.Barcode);
            extendedData.SetValue(Constants.ExtendedDataKeys.Price, productVariant.Price.ToString(CultureInfo.InvariantCulture));
            extendedData.SetValue(Constants.ExtendedDataKeys.OnSale, productVariant.OnSale.ToString());
            extendedData.SetValue(Constants.ExtendedDataKeys.Manufacturer, productVariant.Manufacturer);
            extendedData.SetValue(Constants.ExtendedDataKeys.ManufacturerModelNumber, productVariant.ManufacturerModelNumber);
            extendedData.SetValue(Constants.ExtendedDataKeys.SalePrice, productVariant.SalePrice.ToString(CultureInfo.InvariantCulture));
            extendedData.SetValue(Constants.ExtendedDataKeys.TrackInventory, productVariant.TrackInventory.ToString());
            extendedData.SetValue(Constants.ExtendedDataKeys.OutOfStockPurchase, productVariant.OutOfStockPurchase.ToString());
            extendedData.SetValue(Constants.ExtendedDataKeys.Taxable, productVariant.Taxable.ToString());
            extendedData.SetValue(Constants.ExtendedDataKeys.Shippable, productVariant.Shippable.ToString());
            extendedData.SetValue(Constants.ExtendedDataKeys.Download, productVariant.Download.ToString());
            extendedData.SetValue(Constants.ExtendedDataKeys.DownloadMediaId, productVariant.DownloadMediaId.ToString(CultureInfo.InvariantCulture));
        }
    }
}