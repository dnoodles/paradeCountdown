<template>
  <div class="layout-padding row justify-center">
    <div style="width: 500px; max-width: 90vw;">
      <p class="caption">2016 Gallery</p>
      <q-gallery-carousel dots infinite autoplay :src="secondSlider"></q-gallery-carousel>
    </div>
  </div>
</template>

<script>
import {
  QGallery,
  QGalleryCarousel
} from 'quasar'
export default {
  components: {
    QGallery,
    QGalleryCarousel
  },
  data () {
    return {
      secondSlider: [
      ]
    }
  }
}
</script>