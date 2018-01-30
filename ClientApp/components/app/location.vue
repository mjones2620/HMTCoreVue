<template>
    <section id="location" class="parallax">
        <div class="parallax-overlay">
            <gallery :images="filteredImages" :index="index" v-on:close="index = null"></gallery>
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="text-center">
                            <h2>Practice Locations</h2>
                            <hr class="botm-line" />
                        </div>
                        <div class="panel-group">
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" href="#fredericksburg">Fredericksburg, VA [Main Branch]</a>
                                    </h4>
                                </div>
                                <div id="fredericksburg" class="panel-collapse collapse in">
                                    <div class="panel-body">
                                        <div class="row">
                                            <div class="col-xs-12">
                                                <h4>Business Address</h4>
                                                <p>
                                                    4528 Plank Rd
                                                    <br /> Suite A1
                                                    <br /> Fredericksburg VA 22407
                                                </p>
                                                <p>
                                                    540-845-6940
                                                </p>
                                                <!-- <h4>Directions and Parking</h4>
                                                <em>
                                                    Car
                                                </em>
                                                <p>
                                                    There is parking along the cross streets at First St. and Powhatan St. There is also parking along N Columbus St. Please
                                                    be mindful of all parking rules and regulations posted. I would recommend
                                                    allowing for a few extra minutes before appointments for parking. The
                                                    community manager of the building has notified me they are working on
                                                    guest spots in the parking garage of our building.
                                                </p>
                                                <em>
                                                    Metro
                                                </em>
                                                <p>
                                                    We are conveniently located near the metro line. The nearest metro stop is Braddock Road (approximately a 0.7 mile walk from
                                                    here).
                                                </p>
                                                <em>
                                                    Bus
                                                </em>
                                                <p>
                                                    There is a bus stop 0.1 miles from our building at the corner of Madison St & Washington St.
                                                </p> -->
                                                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3131.686270127387!2d-77.54019898431305!3d38.286764790309206!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89b6c05d91237559%3A0x7acc443ade4cc710!2s4528+Plank+Rd+A1%2C+Fredericksburg%2C+VA+22407!5e0!3m2!1sen!2sus!4v1517341500569"
                                                    width="100%" frameborder="0" height="500" style="border:0" allowfullscreen></iframe>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        <div class="clearfix"></div>
                        <br />
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a data-toggle="collapse" href="#alexandria">Alexandria, VA</a>
                                </h4>
                            </div>
                            <div id="alexandria" class="panel-collapse collapse">
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-xs-12">
                                            <h4>Image Gallery</h4>
                                            <div class="gallery">
                                                <carousel :autoplay='true' :perPage="10" :autoplayTimeout='20000'>
                                                    <slide v-for="(image, imageIndex) in filteredImages" :key="imageIndex">
                                                        <figure>
                                                            <img class="img-responsive" :src="image" v-on:click="index = imageIndex" />
                                                        </figure>
                                                    </slide>
                                                </carousel>
                                            </div>
                                            <h4>Business Address</h4>
                                            <p>
                                                905 N Washington St
                                                <br /> Suite 322
                                                <br /> Alexandria VA 22314
                                            </p>
                                            <p>
                                                703-408-3512
                                            </p>
                                            <!-- <h4>Directions and Parking</h4>
                                                <em>
                                                    Car
                                                </em>
                                                <p>
                                                    There is parking along the cross streets at First St. and Powhatan St. There is also parking along N Columbus St. Please
                                                    be mindful of all parking rules and regulations posted. I would recommend
                                                    allowing for a few extra minutes before appointments for parking. The
                                                    community manager of the building has notified me they are working on
                                                    guest spots in the parking garage of our building.
                                                </p>
                                                <em>
                                                    Metro
                                                </em>
                                                <p>
                                                    We are conveniently located near the metro line. The nearest metro stop is Braddock Road (approximately a 0.7 mile walk from
                                                    here).
                                                </p>
                                                <em>
                                                    Bus
                                                </em>
                                                <p>
                                                    There is a bus stop 0.1 miles from our building at the corner of Madison St & Washington St.
                                                </p> -->
                                            <iframe frameborder="0" border="0" height="500" width="100%" src="https://www.google.com/maps/embed/v1/place?key=AIzaSyD6qRc9aCuO8QP4OOBnV4XVGlYA8LNafUo&q=950+N+Washington+St+%23322,+Alexandria,+VA+22314/@38.815133,-77.0473457,17z"
                                                allowfullscreen></iframe>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        </div>
                        <div class="clearfix"></div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </section>
</template>

<script>
    import VueGallery from "vue-gallery";
    import {
        Carousel,
        Slide
    } from 'vue-carousel';

    export default {
        name: "facility",
        components: {
            gallery: VueGallery,
            Carousel,
            Slide
        },
        data() {
            return {
                images: [],
                index: null
            };
        },
        computed: {
            filteredImages() {
                if (this.images) {
                    var fullPaths = [];
                    this.images.forEach(image => {
                        fullPaths.push(`'../../images/${image}`);
                    });
                    return fullPaths;
                }
                return [];
            }
        },
        created() {
            this.$http.get("Images").then(response => {
                this.images = response.data;
            });
        }
    };
</script>